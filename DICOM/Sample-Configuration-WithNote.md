```json
{
    "rules": [
        {"tag":"(0008,0050)", "method":"redact"}, //Accession Number
        {"tag":"(0018,4000)", "method":"remove"}, //Acquisition Comments
        {"tag":"(0040,0555)", "method":"remove"}, //Acquisition Context Sequence
        {"tag":"(0008,0022)", "method":"remove"}, //Acquisition Date
        {"tag":"(0008,002A)", "method":"remove"}, //Acquisition DateTime
        {"tag":"(0018,1400)", "method":"remove"}, //Acquisition Device Processing Description
        {"tag":"(0018,9424)", "method":"remove"}, //Acquisition Protocol Description
        {"tag":"(0008,0032)", "method":"remove"}, //Acquisition Time
        {"tag":"(0040,4035)", "method":"remove"}, //Actual Human Performers Sequence
        {"tag":"(0010,21B0)", "method":"remove"}, //Additional Patient's History
        {"tag":"(0040,A353)", "method":"remove"}, //Address (Trial)
        {"tag":"(0038,0010)", "method":"remove"}, //Admission ID
        {"tag":"(0038,0020)", "method":"remove"}, //Admitting Date
        {"tag":"(0008,1084)", "method":"remove"}, //Admitting Diagnoses Code Sequence
        {"tag":"(0008,1080)", "method":"remove"}, //Admitting Diagnoses Description
        {"tag":"(0038,0021)", "method":"remove"}, //Admitting Time
        {"tag":"(0000,1000)", "method":"remove"}, //Affected SOP Instance UID
        {"tag":"(0010,2110)", "method":"remove"}, //Allergies
        {"tag":"(4000,0010)", "method":"remove"}, //Arbitrary
        {"tag":"(0040,A078)", "method":"remove"}, //Author Observer Sequence
        {"tag":"(300A,00C3)", "method":"remove"}, //Beam Description
        {"tag":"(300A,00DD)", "method":"remove"}, //Bolus Description
        {"tag":"(0010,1081)", "method":"remove"}, //Branch of Service
        {"tag":"(0018,1007)", "method":"remove"}, //Cassette ID
        {"tag":"(0040,0280)", "method":"remove"}, //Comments on the Performed Procedure Step
        {"tag":"(300A,02EB)", "method":"remove"}, //Compensator Description
        {"tag":"(0020,9161)", "method":"refreshUID"}, //Concatenation UID
        {"tag":"(0040,3001)", "method":"remove"}, //Confidentiality Constraint on Patient Data Description
        {"tag":"(0008,009C)", "method":"redact"}, //Consulting Physician's Name
        {"tag":"(0008,009D)", "method":"remove"}, //Consulting Physician Identification Sequence
        {"tag":"(0070,0086)", "method":"remove"}, //Content Creator's Identification Code Sequence
        {"tag":"(0070,0084)", "method":"redact"}, //Content Creator's Name
        {"tag":"(0008,0023)", "method":"dateshift"}, //Content Date
        {"tag":"(0040,A730)", "method":"redact"}, //Content Sequence
        {"tag":"(0008,0033)", "method":"redact"}, //Content Time
        {"tag":"(0018,0010)", "method":"redact"}, //Contrast Bolus Agent
        {"tag":"(0018,A003)", "method":"remove"}, //Contribution Description
        {"tag":"(0010,2150)", "method":"remove"}, //Country of Residence
        {"tag":"(0040,A307)", "method":"remove"}, //Current Observer (Trial)
        {"tag":"(0038,0300)", "method":"remove"}, //Current Patient Location
        {"tag":"(50xx,xxxx)", "method":"remove"}, //Curve Data
        {"tag":"(0008,0025)", "method":"remove"}, //Curve Date
        {"tag":"(0008,0035)", "method":"remove"}, //Curve Time
        {"tag":"(0040,A07C)", "method":"remove"}, //Custodial Organization Sequence
        {"tag":"(FFFC,FFFC)", "method":"remove"}, //Data Set Trailing Padding
        {"tag":"(0008,2111)", "method":"remove"}, //Derivation Description
        {"tag":"(0018,700A)", "method":"remove"}, //Detector ID
        {"tag":"(0018,1000)", "method":"remove"}, //Device Serial Number
        {"tag":"(0018,1002)", "method":"refreshUID"}, //Device UID
        {"tag":"(FFFA,FFFA)", "method":"remove"}, //Digital Signatures Sequence
        {"tag":"(0400,0100)", "method":"refreshUID"}, //Digital Signature UID
        {"tag":"(0020,9164)", "method":"refreshUID"}, //Dimension Organization UID
        {"tag":"(0038,0040)", "method":"remove"}, //Discharge Diagnosis Description
        {"tag":"(4008,011A)", "method":"remove"}, //Distribution Address
        {"tag":"(4008,0119)", "method":"remove"}, //Distribution Name
        {"tag":"(300A,0016)", "method":"remove"}, //Dose Reference Description
        {"tag":"(300A,0013)", "method":"refreshUID"}, //Dose Reference UID
        {"tag":"(0018,9517)", "method":"remove"}, //End Acquisition DateTime
        {"tag":"(0010,2160)", "method":"remove"}, //Ethnic Group
        {"tag":"(0040,4011)", "method":"remove"}, //Expected Completion DateTime
        {"tag":"(0008,0058)", "method":"refreshUID"}, //Failed SOP Instance UID List
        {"tag":"(0070,031A)", "method":"refreshUID"}, //Fiducial UID
        {"tag":"(0040,2017)", "method":"redact"}, //Filler Order Number / Imaging Service Request
        {"tag":"(3008,0054)", "method":"remove"}, //First Treatment Date
        {"tag":"(300A,0196)", "method":"remove"}, //Fixation Device Description
        {"tag":"(300A,0072)", "method":"remove"}, //Fraction Group Description
        {"tag":"(0020,9158)", "method":"remove"}, //Frame Comments
        {"tag":"(0020,0052)", "method":"refreshUID"}, //Frame of Reference UID
        {"tag":"(0018,1008)", "method":"remove"}, //Gantry ID
        {"tag":"(0018,1005)", "method":"remove"}, //Generator ID
        {"tag":"(0070,0001)", "method":"redact"}, //Graphic Annotation Sequence
        {"tag":"(0040,4037)", "method":"remove"}, //Human Performers Name
        {"tag":"(0040,4036)", "method":"remove"}, //Human Performers Organization
        {"tag":"(0088,0200)", "method":"remove"}, //Icon Image Sequence(see Note 12)
        {"tag":"(0008,4000)", "method":"remove"}, //Identifying Comments
        {"tag":"(0020,4000)", "method":"remove"}, //Image Comments
        {"tag":"(0028,4000)", "method":"remove"}, //Image Presentation Comments
        {"tag":"(0040,2400)", "method":"remove"}, //Imaging Service Request Comments
        {"tag":"(4008,0300)", "method":"remove"}, //Impressions
        {"tag":"(0008,0015)", "method":"remove"}, //Instance Coercion DateTime
        {"tag":"(0008,0014)", "method":"refreshUID"}, //Instance Creator UID
        {"tag":"(0400,0600)", "method":"remove"}, //Instance Origin Status
        {"tag":"(0008,0081)", "method":"remove"}, //Institution Address
        {"tag":"(0008,1040)", "method":"remove"}, //Institutional Department Name
        {"tag":"(0008,1041)", "method":"remove"}, //Institutional Department Type Code Sequence
        {"tag":"(0008,0082)", "method":"remove"}, //Institution Code Sequence
        {"tag":"(0008,0080)", "method":"remove"}, //Institution Name
        {"tag":"(0010,1050)", "method":"remove"}, //Insurance Plan Identification
        {"tag":"(0040,1011)", "method":"remove"}, //Intended Recipients of Results Identification Sequence
        {"tag":"(4008,0111)", "method":"remove"}, //Interpretation Approver Sequence
        {"tag":"(4008,010C)", "method":"remove"}, //Interpretation Author
        {"tag":"(4008,0115)", "method":"remove"}, //Interpretation Diagnosis Description
        {"tag":"(4008,0202)", "method":"remove"}, //Interpretation ID Issuer
        {"tag":"(4008,0102)", "method":"remove"}, //Interpretation Recorder
        {"tag":"(4008,010B)", "method":"remove"}, //Interpretation Text
        {"tag":"(4008,010A)", "method":"remove"}, //Interpretation Transcriber
        {"tag":"(0008,3010)", "method":"refreshUID"}, //Irradiation Event UID
        {"tag":"(0038,0011)", "method":"remove"}, //Issuer of Admission ID
        {"tag":"(0038,0014)", "method":"remove"}, //Issuer of Admission ID Sequence
        {"tag":"(0010,0021)", "method":"remove"}, //Issuer of Patient ID
        {"tag":"(0038,0061)", "method":"remove"}, //Issuer of Service Episode ID
        {"tag":"(0038,0064)", "method":"remove"}, //Issuer of Service Episode ID Sequence
        {"tag":"(0028,1214)", "method":"refreshUID"}, //Large Palette Color Lookup Table UID
        {"tag":"(0010,21D0)", "method":"remove"}, //Last Menstrual Date
        {"tag":"(0400,0404)", "method":"remove"}, //MAC
        {"tag":"(0002,0003)", "method":"refreshUID"}, //Media Storage SOP Instance UID
        {"tag":"(0010,2000)", "method":"remove"}, //Medical Alerts
        {"tag":"(0010,1090)", "method":"remove"}, //Medical Record Locator
        {"tag":"(0010,1080)", "method":"remove"}, //Military Rank
        {"tag":"(0400,0550)", "method":"remove"}, //Modified Attributes Sequence
        {"tag":"(0020,3406)", "method":"remove"}, //Modified Image Description
        {"tag":"(0020,3401)", "method":"remove"}, //Modifying Device ID
        {"tag":"(3008,0056)", "method":"remove"}, //Most Recent Treatment Date
        {"tag":"(0008,1060)", "method":"remove"}, //Name of Physician(s) Reading Study
        {"tag":"(0040,1010)", "method":"remove"}, //Names of Intended Recipient of Results
        {"tag":"(0040,A192)", "method":"remove"}, //Observation Date (Trial)
        {"tag":"(0040,A402)", "method":"refreshUID"}, //Observation Subject UID (Trial)
        {"tag":"(0040,A193)", "method":"remove"}, //Observation Time (Trial)
        {"tag":"(0040,A171)", "method":"refreshUID"}, //Observation UID
        {"tag":"(0010,2180)", "method":"remove"}, //Occupation
        {"tag":"(0008,1072)", "method":"remove"}, //Operators' Identification Sequence
        {"tag":"(0008,1070)", "method":"remove"}, //Operators' Name
        {"tag":"(0040,2010)", "method":"remove"}, //Order Callback Phone Number
        {"tag":"(0040,2011)", "method":"remove"}, //Order Callback Telecom Information
        {"tag":"(0040,2008)", "method":"remove"}, //Order Entered By
        {"tag":"(0040,2009)", "method":"remove"}, //Order Enterer Location
        {"tag":"(0400,0561)", "method":"remove"}, //Original Attributes Sequence
        {"tag":"(0010,1000)", "method":"remove"}, //Other Patient IDs
        {"tag":"(0010,1002)", "method":"remove"}, //Other Patient IDs Sequence
        {"tag":"(0010,1001)", "method":"remove"}, //Other Patient Names
        {"tag":"(60xx,4000)", "method":"remove"}, //Overlay Comments
        {"tag":"(60xx,3000)", "method":"remove"}, //Overlay Data
        {"tag":"(0008,0024)", "method":"remove"}, //Overlay Date
        {"tag":"(0008,0034)", "method":"remove"}, //Overlay Time
        {"tag":"(0028,1199)", "method":"refreshUID"}, //Palette Color Lookup Table UID
        {"tag":"(0040,A07A)", "method":"remove"}, //Participant Sequence
        {"tag":"(0010,1010)", "method":"remove"}, //Patient's Age
        {"tag":"(0010,0030)", "method":"redact"}, //Patient's Birth Date
        {"tag":"(0010,1005)", "method":"remove"}, //Patient's Birth Name
        {"tag":"(0010,0032)", "method":"remove"}, //Patient's Birth Time
        {"tag":"(0038,0400)", "method":"remove"}, //Patient's Institution Residence
        {"tag":"(0010,0050)", "method":"remove"}, //Patient's Insurance Plan Code Sequence
        {"tag":"(0010,1060)", "method":"remove"}, //Patient's Mother's Birth Name
        {"tag":"(0010,0010)", "method":"redact"}, //Patient's Name
        {"tag":"(0010,0101)", "method":"remove"}, //Patient's Primary Language Code Sequence
        {"tag":"(0010,0102)", "method":"remove"}, //Patient's Primary Language Modifier Code Sequence
        {"tag":"(0010,21F0)", "method":"remove"}, //Patient's Religious Preference
        {"tag":"(0010,0040)", "method":"redact"}, //Patient's Sex
        {"tag":"(0010,1020)", "method":"remove"}, //Patient's Size
        {"tag":"(0010,2155)", "method":"remove"}, //Patient's Telecom Information
        {"tag":"(0010,2154)", "method":"remove"}, //Patient's Telephone Numbers
        {"tag":"(0010,1030)", "method":"remove"}, //Patient's Weight
        {"tag":"(0010,1040)", "method":"remove"}, //Patient Address
        {"tag":"(0010,4000)", "method":"remove"}, //Patient Comments
        {"tag":"(0010,0020)", "method":"redact"}, //Patient ID
        {"tag":"(0010,2203)", "method":"remove"}, //Patient Sex Neutered
        {"tag":"(0038,0500)", "method":"remove"}, //Patient State
        {"tag":"(0040,1004)", "method":"remove"}, //Patient Transport Arrangements
        {"tag":"(0040,0243)", "method":"remove"}, //Performed Location
        {"tag":"(0040,0254)", "method":"remove"}, //Performed Procedure Step Description
        {"tag":"(0040,0250)", "method":"remove"}, //Performed Procedure Step End Date
        {"tag":"(0040,4051)", "method":"remove"}, //Performed Procedure Step End DateTime
        {"tag":"(0040,0251)", "method":"remove"}, //Performed Procedure Step End Time
        {"tag":"(0040,0253)", "method":"remove"}, //Performed Procedure Step ID
        {"tag":"(0040,0244)", "method":"remove"}, //Performed Procedure Step Start Date
        {"tag":"(0040,4050)", "method":"remove"}, //Performed Procedure Step Start DateTime
        {"tag":"(0040,0245)", "method":"remove"}, //Performed Procedure Step Start Time
        {"tag":"(0040,0241)", "method":"remove"}, //Performed Station AE Title
        {"tag":"(0040,4030)", "method":"remove"}, //Performed Station Geographic Location Code Sequence
        {"tag":"(0040,0242)", "method":"remove"}, //Performed Station Name
        {"tag":"(0040,4028)", "method":"remove"}, //Performed Station Name Code Sequence
        {"tag":"(0008,1052)", "method":"remove"}, //Performing Physician Identification Sequence
        {"tag":"(0008,1050)", "method":"remove"}, //Performing Physicians' Name
        {"tag":"(0040,1104)", "method":"remove"}, //Person's Telecom Information
        {"tag":"(0040,1103)", "method":"remove"}, //Person's Telephone Numbers
        {"tag":"(0040,1102)", "method":"remove"}, //Person Address
        {"tag":"(0040,1101)", "method":"redact"}, //Person Identification Code Sequence
        {"tag":"(0040,A123)", "method":"cryptoHash"}, //Person Name
        {"tag":"(0008,1048)", "method":"remove"}, //Physician(s) of Record
        {"tag":"(0008,1049)", "method":"remove"}, //Physician(s) of Record Identification Sequence
        {"tag":"(0008,1062)", "method":"remove"}, //Physician(s) Reading Study Identification Sequence
        {"tag":"(4008,0114)", "method":"remove"}, //Physician Approving Interpretation
        {"tag":"(0040,2016)", "method":"redact"}, //Placer Order Number / Imaging Service Request
        {"tag":"(0018,1004)", "method":"remove"}, //Plate ID
        {"tag":"(0010,21C0)", "method":"remove"}, //Pregnancy Status
        {"tag":"(0040,0012)", "method":"remove"}, //Pre-Medication
        {"tag":"(300A,000E)", "method":"remove"}, //Prescription Description
        {"tag":"(0070,1101)", "method":"refreshUID"}, //Presentation Display Collection UID
        {"tag":"(0070,1102)", "method":"refreshUID"}, //Presentation Sequence Collection UID
        {"tag":"(0040,4052)", "method":"remove"}, //Procedure Step Cancellation DateTime
        {"tag":"(0018,1030)", "method":"remove"}, //Protocol Name
        {"tag":"(300C,0113)", "method":"remove"}, //Reason for Omission Description
        {"tag":"(0032,1030)", "method":"remove"}, //Reason for Study
        {"tag":"(0040,2001)", "method":"remove"}, //Reason for the Imaging Service Request
        {"tag":"(0400,0402)", "method":"remove"}, //Referenced Digital Signature Sequence
        {"tag":"(300A,0083)", "method":"refreshUID"}, //Referenced Dose Reference UID
        {"tag":"(3006,0024)", "method":"refreshUID"}, //Referenced Frame of Reference UID
        {"tag":"(0040,4023)", "method":"refreshUID"}, //Referenced General Purpose Scheduled Procedure Step Transaction UID
        {"tag":"(0008,1140)", "method":"remove"}, //Referenced Image Sequence
        {"tag":"(0040,A172)", "method":"refreshUID"}, //Referenced Observation UID (Trial)
        {"tag":"(0038,0004)", "method":"remove"}, //Referenced Patient Alias Sequence
        {"tag":"(0010,1100)", "method":"remove"}, //Referenced Patient Photo Sequence
        {"tag":"(0008,1120)", "method":"remove"}, //Referenced Patient Sequence
        {"tag":"(0008,1111)", "method":"remove"}, //Referenced Performed Procedure Step Sequence
        {"tag":"(0400,0403)", "method":"remove"}, //Referenced SOP Instance MAC Sequence
        {"tag":"(0008,1155)", "method":"refreshUID"}, //Referenced SOP Instance UID
        {"tag":"(0004,1511)", "method":"refreshUID"}, //Referenced SOP Instance UID in File
        {"tag":"(0008,1110)", "method":"remove"}, //Referenced Study Sequence
        {"tag":"(0008,0092)", "method":"remove"}, //Referring Physician's Address
        {"tag":"(0008,0090)", "method":"redact"}, //Referring Physician's Name
        {"tag":"(0008,0094)", "method":"remove"}, //Referring Physician's Telephone Numbers
        {"tag":"(0008,0096)", "method":"remove"}, //Referring Physician Identification Sequence
        {"tag":"(0010,2152)", "method":"remove"}, //Region of Residence
        {"tag":"(3006,00C2)", "method":"refreshUID"}, //Related Frame of Reference UID
        {"tag":"(0040,0275)", "method":"remove"}, //Request Attributes Sequence
        {"tag":"(0032,1070)", "method":"remove"}, //Requested Contrast Agent
        {"tag":"(0040,1400)", "method":"remove"}, //Requested Procedure Comments
        {"tag":"(0032,1060)", "method":"remove"}, //Requested Procedure Description
        {"tag":"(0040,1001)", "method":"remove"}, //Requested Procedure ID
        {"tag":"(0040,1005)", "method":"remove"}, //Requested Procedure Location
        {"tag":"(0000,1001)", "method":"refreshUID"}, //Requested SOP Instance UID
        {"tag":"(0032,1032)", "method":"remove"}, //Requesting Physician
        {"tag":"(0032,1033)", "method":"remove"}, //Requesting Service
        {"tag":"(0018,9185)", "method":"remove"}, //Respiratory Motion Compensation Technique Description
        {"tag":"(0010,2299)", "method":"remove"}, //Responsible Organization
        {"tag":"(0010,2297)", "method":"remove"}, //Responsible Person
        {"tag":"(4008,4000)", "method":"remove"}, //Results Comments
        {"tag":"(4008,0118)", "method":"remove"}, //Results Distribution List Sequence
        {"tag":"(4008,0042)", "method":"remove"}, //Results ID Issuer
        {"tag":"(300E,0008)", "method":"remove"}, //Reviewer Name
        {"tag":"(300A,0006)", "method":"remove"}, //RT Plan Date
        {"tag":"(300A,0004)", "method":"remove"}, //RT Plan Description
        {"tag":"(300A,0002)", "method":"substitute", "params":{"replaceWith": "ANONY"}}, //RT Plan Label
        {"tag":"(300A,0003)", "method":"remove"}, //RT Plan Name
        {"tag":"(300A,0007)", "method":"remove"}, //RT Plan Time
        {"tag":"(0040,4034)", "method":"remove"}, //Scheduled Human Performers Sequence
        {"tag":"(0038,001E)", "method":"remove"}, //Scheduled Patient Institution Residence
        {"tag":"(0040,000B)", "method":"remove"}, //Scheduled Performing Physician Identification Sequence
        {"tag":"(0040,0006)", "method":"remove"}, //Scheduled Performing Physician Name
        {"tag":"(0040,0007)", "method":"remove"}, //Scheduled Procedure Step Description
        {"tag":"(0040,0004)", "method":"remove"}, //Scheduled Procedure Step End Date
        {"tag":"(0040,0005)", "method":"remove"}, //Scheduled Procedure Step End Time
        {"tag":"(0040,4008)", "method":"remove"}, //Scheduled Procedure Step Expiration DateTime
        {"tag":"(0040,0011)", "method":"remove"}, //Scheduled Procedure Step Location
        {"tag":"(0040,4010)", "method":"remove"}, //Scheduled Procedure Step Modification DateTime
        {"tag":"(0040,0002)", "method":"remove"}, //Scheduled Procedure Step Start Date
        {"tag":"(0040,4005)", "method":"remove"}, //Scheduled Procedure Step Start DateTime
        {"tag":"(0040,0003)", "method":"remove"}, //Scheduled Procedure Step Start Time
        {"tag":"(0040,0001)", "method":"remove"}, //Scheduled Station AE Title
        {"tag":"(0040,4027)", "method":"remove"}, //Scheduled Station Geographic Location Code Sequence
        {"tag":"(0040,0010)", "method":"remove"}, //Scheduled Station Name
        {"tag":"(0040,4025)", "method":"remove"}, //Scheduled Station Name Code Sequence
        {"tag":"(0032,1020)", "method":"remove"}, //Scheduled Study Location
        {"tag":"(0032,1021)", "method":"remove"}, //Scheduled Study Location AE Title
        {"tag":"(0008,0021)", "method":"remove"}, //Series Date
        {"tag":"(0008,103E)", "method":"remove"}, //Series Description
        {"tag":"(0020,000E)", "method":"refreshUID"}, //Series Instance UID
        {"tag":"(0008,0031)", "method":"remove"}, //Series Time
        {"tag":"(0038,0062)", "method":"remove"}, //Service Episode Description
        {"tag":"(0038,0060)", "method":"remove"}, //Service Episode ID
        {"tag":"(300A,01B2)", "method":"remove"}, //Setup- Technique Description
        {"tag":"(300A,01A6)", "method":"remove"}, //Shielding Device Description
        {"tag":"(0010,21A0)", "method":"remove"}, //Smoking Status
        {"tag":"(0008,0018)", "method":"refreshUID"}, //SOP Instance UID
        {"tag":"(0008,2112)", "method":"remove"}, //Source Image Sequence
        {"tag":"(300A,0216)", "method":"remove"}, //Source Manufacturer
        {"tag":"(3008,0105)", "method":"remove"}, //Source Serial Number
        {"tag":"(3008,0105)", "method":"remove"}, //Source Serial Number
        {"tag":"(0038,0050)", "method":"remove"}, //Special Needs
        {"tag":"(0018,9516)", "method":"remove"}, //Start Acquisition DateTime
        {"tag":"(0008,1010)", "method":"remove"}, //Station Name
        {"tag":"(0088,0140)", "method":"refreshUID"}, //Storage Media File-set UID
        {"tag":"(0032,4000)", "method":"remove"}, //Study Comments
        {"tag":"(0008,0020)", "method":"redact"}, //Study Date
        {"tag":"(0008,1030)", "method":"remove"}, //Study Description
        {"tag":"(0020,0010)", "method":"redact"}, //Study ID
        {"tag":"(0032,0012)", "method":"remove"}, //Study ID Issuer
        {"tag":"(0020,000D)", "method":"refreshUID"}, //Study Instance UID
        {"tag":"(0008,0030)", "method":"redact"}, //Study Time
        {"tag":"(0020,0200)", "method":"refreshUID"}, //Synchronization Frame of Reference UID
        {"tag":"(0018,2042)", "method":"refreshUID"}, //Target UID
        {"tag":"(0040,A354)", "method":"remove"}, //Telephone Number (Trial)
        {"tag":"(0040,DB0D)", "method":"refreshUID"}, //Template Extension Creator UID
        {"tag":"(0040,DB0C)", "method":"refreshUID"}, //Template Extension Organization UID
        {"tag":"(4000,4000)", "method":"remove"}, //Text Comments
        {"tag":"(2030,0020)", "method":"remove"}, //Text String
        {"tag":"(0008,0201)", "method":"remove"}, //Timezone Offset From UTC
        {"tag":"(0088,0910)", "method":"remove"}, //Topic Author
        {"tag":"(0088,0912)", "method":"remove"}, //Topic Keywords
        {"tag":"(0088,0906)", "method":"remove"}, //Topic Subject
        {"tag":"(0088,0904)", "method":"remove"}, //Topic Title
        {"tag":"(0062,0021)", "method":"refreshUID"}, //Tracking UID
        {"tag":"(0008,1195)", "method":"refreshUID"}, //Transaction UID
        {"tag":"(3008,0250)", "method":"remove"}, //Treatment Date
        {"tag":"(300A,00B2)", "method":"remove"}, //Treatment Machine Name
        {"tag":"(3008,0251)", "method":"remove"}, //Treatment Time
        {"tag":"(0040,A124)", "method":"refreshUID"}, //UID
        {"tag":"(0040,A352)", "method":"remove"}, //Verbal Source (Trial)
        {"tag":"(0040,A358)", "method":"remove"}, //Verbal Source Identifier Code Sequence (Trial)
        {"tag":"(0040,A088)", "method":"redact"}, //Verifying Observer Identification Code Sequence
        {"tag":"(0040,A075)", "method":"cryptoHash"}, //Verifying Observer Name
        {"tag":"(0040,A073)", "method":"redact"}, //Verifying Observer Sequence
        {"tag":"(0040,A027)", "method":"substitute"}, //Verifying Organization
        {"tag":"(0038,4000)", "method":"remove"}, //Visit Comments
        {"tag":"DA", "method":"dateshift"},
        {"tag":"DT", "method":"dateshift"}
    ],

    "profile": [
        "MINIMAL_KEEP_LIST_PROFILE"
    ],
    "defaultSettings": {
        "perturb": {
            "span": 1,
            "roundTo": 2,
            "rangeType": "Proportional",
            "distribution": "Uniform"
        },
        "dateShift": {
            "dateShiftKey": "123",
            "dateShiftScope": "SeriesInstance",
            "dateShiftRange": 50
        },   
        "cryptoHash": {
            "cryptoHashKey": "123",
            "cryptoHashFunction": "hmacsha256"
        },
        "redact": {
            "enablePartialAgesForRedact": false,
            "enablePartialDatesForRedact": false
        },
        "encrypt": {
            "encryptKey": "123456781234567812345678"
        },
        "substitute": {
            "replaceWith": "ANONYMOUS"
        }
    },
    "customSettings": {
        "perturbCustomerSetting": {
            "span": 1,
            "roundTo": 2,
            "rangeType": "Proportional",
            "distribution": "Uniform"
        }
    }
}
```