﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dicom;
using Dicom.IO.Buffer;
using Microsoft.Health.Dicom.Anonymizer.Core.Exceptions;
using Microsoft.Health.Dicom.Anonymizer.Core.Processors;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Microsoft.Health.Dicom.Anonymizer.Core.UnitTests.Processors
{
    public class CryptoHashProcessorUnitTests
    {
        public CryptoHashProcessorUnitTests()
        {
            var json = "{\"cryptoHashKey\": \"123\"}";
            Processor = new CryptoHashProcessor(JObject.Parse(json));
        }

        public CryptoHashProcessor Processor { get; set; }

        public static IEnumerable<object[]> GetUnsupportedVRItemForCryptoHash()
        {
            yield return new object[] { DicomTag.Longitudinal​Temporal​Offset​From​Event, "12345" }; // FD
            yield return new object[] { DicomTag.Examined​Body​Thickness, "12345" }; // FL
            yield return new object[] { DicomTag.Doppler​Sample​Volume​X​Position, "12345" }; // SL
            yield return new object[] { DicomTag.Real​World​Value​First​Value​Mapped, "12345" }; // SS
            yield return new object[] { DicomTag.Referenced​Content​Item​Identifier, "12345" }; // UL
            yield return new object[] { DicomTag.Referenced​Waveform​Channels, "12345\\1234" }; // US
        }

        public static IEnumerable<object[]> GetSupportedVRItemForCryptoHash()
        {
            yield return new object[] { DicomTag.Consulting​Physician​Name, "Test\\Test", @"d61ffce34b0192c52d7a67215be73f1e2d640d01383dd8115170b9bd20779a91\d61ffce34b0192c52d7a67215be73f1e2d640d01383dd8115170b9bd20779a91" }; // PN
            yield return new object[] { DicomTag.Long​Code​Value, "TEST", "2e7acefff0307262cef6f503fa7019257f3f9d47fc987fb2c5a31ae4f4d3c022" }; // UC
            yield return new object[] { DicomTag.Event​Timer​Names, "TestTimer", "967df06624010af6b86a019e26aff938976a82e947e96331d8f1fdf387a88089" }; // LO
            yield return new object[] { DicomTag.Strain​Additional​Information, "TestInformation", "70267ad9b166401a6cd6939564dcb70264bb5a62809948e83eebc1a233f43617" }; // UT
            yield return new object[] { DicomTag.Derivation​Description, "TestDescription", "79a5ed3e37eba9bcd14cc30759916ad5df394047a2fed4ad69f1d8ec5edc5337" }; // ST
            yield return new object[] { DicomTag.Pixel​Data​Provider​URL, "http://test", "4983fd14ec2878e50c454764a0d02654ae76fe1001557847b031435100acc9a1" }; // LT
        }

        public static IEnumerable<object[]> GetSupportedVRItemForCryptoHashButOutputExceedLengthLimitation()
        {
            // Invalid output length limitation
            yield return new object[] { DicomTag.RetrieveAETitle, "TEST", "2e7acefff0307262cef6f503fa7019257f3f9d47fc987fb2c5a31ae4f4d3c022" }; // AE
            yield return new object[] { DicomTag.PatientAge, "100Y", "0329e399cd57ed8b21172ede4ae295f549c3d6ece0d292c01a707531d133936e" }; // AS
            yield return new object[] { DicomTag.Query​Retrieve​Level, "0", "976feb2c9f52ff3c8114901e9913be50063f50b1683ea556f1fe47d449cc5583" }; // CS
            yield return new object[] { DicomTag.Event​Elapsed​Times, "1234.5", "92b95e021c40596706b243f79fe0f45394de785be64866f6b46fcacd0839ac43" }; // DS
            yield return new object[] { DicomTag.Stage​Number, "1234", "c1771ad95972ef1ab887140489863ede4faad7458441a3a8a4781454e368b52d" }; // IS
            yield return new object[] { DicomTag.Patient​Telephone​Numbers, "TEST", "2e7acefff0307262cef6f503fa7019257f3f9d47fc987fb2c5a31ae4f4d3c022" }; // SH
            yield return new object[] { DicomTag.SOP​Classes​In​Study, "12345", "81c7be73b3eaeca31695a744fbc6d3abb5a37ffc10498d0fcb4111c7944b28a0" }; // UI
        }

        [Theory]
        [MemberData(nameof(GetUnsupportedVRItemForCryptoHash))]
        public void GivenUnsupportedVRForCryptoHash_WhenCheckVRIsSupported_ResultWillBeFalse(DicomTag tag, string value)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };

            Assert.False(Processor.IsSupported(dataset.GetDicomItem<DicomElement>(tag)));
        }

        [Theory]
        [MemberData(nameof(GetSupportedVRItemForCryptoHash))]
        [MemberData(nameof(GetSupportedVRItemForCryptoHashButOutputExceedLengthLimitation))]
        public void GivenSupportedVRForCryptoHash_WhenCheckVRIsSupported_ResultWillBeTrue(DicomTag tag, string value, string expectedValue)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };

            Assert.True(Processor.IsSupported(dataset.GetDicomItem<DicomElement>(tag)));
            Assert.NotNull(expectedValue);
        }

        [Theory]
        [MemberData(nameof(GetUnsupportedVRItemForCryptoHash))]
        public void GivenADataSetWithUnsupportedVRForCryptoHash_WhenCryptoHash_ExceptionWillBeThrown(DicomTag tag, string value)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };

            Assert.Throws<AnonymizerOperationException>(() => Processor.Process(dataset, dataset.GetDicomItem<DicomElement>(tag)));
        }

        [Theory]
        [MemberData(nameof(GetSupportedVRItemForCryptoHashButOutputExceedLengthLimitation))]
        public void GivenADataSetWithSupportedVRForCryptoHash_WhenCryptoHashWithAutoValidation_IfOutputExceedLengthLimitation_ExceptionWillBeThrown(DicomTag tag, string value, string result)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };

            Assert.Throws<DicomValidationException>(() => Processor.Process(dataset, dataset.GetDicomItem<DicomElement>(tag)));
            Assert.NotNull(result);
        }

        [Theory]
        [MemberData(nameof(GetSupportedVRItemForCryptoHashButOutputExceedLengthLimitation))]
        public void GivenADataSetWithSupportedVRForCryptoHash_WhenCryptoHashWithoutAutoValidation_IfOutputExceedLengthLimitation_ResultWillBeReturned(DicomTag tag, string value, string result)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };
            DicomUtility.DisableAutoValidation(dataset);
            Processor.Process(dataset, dataset.GetDicomItem<DicomElement>(tag));
            Assert.Equal(result, dataset.GetDicomItem<DicomElement>(tag).Get<string>());
        }

        [Theory]
        [MemberData(nameof(GetSupportedVRItemForCryptoHash))]
        public void GivenADataSetWithValidVRForCryptoHash_WhenCryptoHash_ItemWillBeHashed(DicomTag tag, string value, string result)
        {
            var dataset = new DicomDataset
            {
                { tag, value },
            };

            Processor.Process(dataset, dataset.GetDicomItem<DicomElement>(tag));
            Assert.Equal(result, dataset.GetDicomItem<DicomElement>(tag).Get<string>());
        }

        [Fact]
        public void GivenADataSetWithDicomElementOB_WhenCheckIsSupported_ResultWillBeTrue()
        {
            var tag = DicomTag.PixelData;
            var item = new DicomOtherByte(tag, Encoding.UTF8.GetBytes("test"));

            Assert.True(Processor.IsSupported(item));
        }

        [Fact]
        public void GivenADataSetWithDicomFragmentSequence_WhenCheckIsSupported_ResultWillBeTrue()
        {
            var tag = DicomTag.PixelData;
            var item = new DicomOtherByteFragment(tag);
            item.Fragments.Add(new MemoryByteBuffer(Convert.FromBase64String("fragment")));
            item.Fragments.Add(new MemoryByteBuffer(Convert.FromBase64String("fragment")));
            Assert.True(Processor.IsSupported(item));
        }

        [Fact]
        public void GivenADataSetWithSQItem_WhenCheckIsSupported_ResultWillBeFalse()
        {
            var sps1 = new DicomDataset { { DicomTag.ScheduledStationName, "1" } };
            var sps2 = new DicomDataset { { DicomTag.ScheduledStationName, "2" } };
            var item = new DicomSequence(DicomTag.ScheduledProcedureStepSequence, sps1, sps2);

            Assert.False(Processor.IsSupported(item));
        }

        [Fact]
        public void GivenADataSetWithDicomElementOB_WhenCryptoHash_ValueWillBeHashed()
        {
            var tag = DicomTag.PixelData;
            var item = new DicomOtherByte(tag, Encoding.UTF8.GetBytes("test"));
            var dataset = new DicomDataset(item);

            Processor.Process(dataset, dataset.GetDicomItem<DicomElement>(tag));
            var resultBytes = dataset.GetDicomItem<DicomOtherByte>(tag).Get<byte[]>();
            Assert.Equal("a7f5c8c626f994482813230854f66700e626208f52d913b9bd6b4e039aab0f41", string.Concat(resultBytes.Select(b => b.ToString("x2"))));
        }

        [Fact]
        public void GivenADataSetWithDicomFragmentSequence_WhenCryptoHash_FragmentsWillBeHashed()
        {
            var tag = DicomTag.PixelData;
            var item = new DicomOtherByteFragment(tag);
            item.Fragments.Add(new MemoryByteBuffer(Convert.FromBase64String("fragment")));
            item.Fragments.Add(new MemoryByteBuffer(Convert.FromBase64String("fragment")));

            var dataset = new DicomDataset(item);

            Processor.Process(dataset, dataset.GetDicomItem<DicomOtherByteFragment>(tag));

            var enumerator = ((DicomFragmentSequence)dataset.GetDicomItem<DicomItem>(tag)).GetEnumerator();
            while (enumerator.MoveNext())
            {
                var resultString = string.Concat(enumerator.Current.Data.Select(b => b.ToString("x2")));
                Assert.Equal("1ad1011bc425028a63a257140287a08d38d0f203e4bdf063b077acf6eca651a9", resultString);
            }
        }

        [Fact]
        public void GivenADataSetWithSQItem_WhenCryptoHash_ExceptionWillBeThrown()
        {
            var dataset = new DicomDataset { };
            var sps1 = new DicomDataset { { DicomTag.ScheduledStationName, "1" } };
            var sps2 = new DicomDataset { { DicomTag.ScheduledStationName, "2" } };
            var spcs1 = new DicomDataset { { DicomTag.ContextIdentifier, "1" } };
            var spcs2 = new DicomDataset { { DicomTag.ContextIdentifier, "2" } };
            var spcs3 = new DicomDataset { { DicomTag.ContextIdentifier, "3" } };
            sps1.Add(new DicomSequence(DicomTag.ScheduledProtocolCodeSequence, spcs1, spcs2));
            sps2.Add(new DicomSequence(DicomTag.ScheduledProtocolCodeSequence, spcs3));
            dataset.Add(new DicomSequence(DicomTag.ScheduledProcedureStepSequence, sps1, sps2));

            Assert.Throws<AnonymizerOperationException>(() => Processor.Process(dataset, dataset.GetDicomItem<DicomItem>(DicomTag.ScheduledProcedureStepSequence)));
        }
    }
}
