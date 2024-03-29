﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.Anonymizer.Common.Settings
{
    public class RedactSetting
    {
        public bool EnablePartialDatesForRedact { get; set; } = false;

        public bool EnablePartialZipCodesForRedact { get; set; } = false;

        public bool EnablePartialAgesForRedact { get; set; } = false;

        public List<string> RestrictedZipCodeTabulationAreas { get; set; } = new List<string>();
    }
}
