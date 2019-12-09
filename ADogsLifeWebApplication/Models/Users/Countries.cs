using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ADogsLifeWebApplication.Models.Users
{
/// <summary>
/// Countries of the world.
/// </summary>
public enum Countries
{
    [Display(Name = "Choose Country...")]
    None = 0,

    [Display(Name = "Afghanistan")] [Description("Afghanistan")]
    AF = 1,

    [Display(Name = "Åland Islands")] [Description("Åland Islands")]
    AX = 2,

    [Display(Name = "Albania")] [Description("Albania")]
    AL = 3,

    [Display(Name = "Algeria")] [Description("Algeria")]
    DZ = 4,

    [Display(Name = "American Samoa")] [Description("American Samoa")]
    AS = 5,

    [Display(Name = "Andorra")] [Description("Andorra")]
    AD = 6,

    [Display(Name = "Angola")] [Description("Angola")]
    AO = 7,

    [Display(Name = "Anguilla")] [Description("Anguilla")]
    AI = 8,

    [Display(Name = "Antarctica")] [Description("Antarctica")]
    AQ = 9,

    [Display(Name = "Antigua and Barbuda")] [Description("Antigua and Barbuda")]
    AG = 10,

    [Display(Name = "Argentina")] [Description("Argentina")]
    AR = 11,

    [Display(Name = "Armenia")] [Description("Armenia")]
    AM = 12,

    [Display(Name = "Aruba")] [Description("Aruba")]
    AW = 13,

    [Display(Name = "Australia")] [Description("Australia")]
    AU = 14,

    [Display(Name = "Austria")] [Description("Austria")]
    AT = 15,

    [Display(Name = "Azerbaijan")] [Description("Azerbaijan")]
    AZ = 16,

    [Display(Name = "Bahamas")] [Description("Bahamas")]
    BS = 17,

    [Display(Name = "Bahrain")] [Description("Bahrain")]
    BH = 18,

    [Display(Name = "Bangladesh")] [Description("Bangladesh")]
    BD = 19,

    [Display(Name = "Barbados")] [Description("Barbados")]
    BB = 20,

    [Display(Name = "Belarus")] [Description("Belarus")]
    BY = 21,

    [Display(Name = "Belgium")] [Description("Belgium")]
    BE = 22,

    [Display(Name = "Belize")] [Description("Belize")]
    BZ = 23,

    [Display(Name = "Benin")] [Description("Benin")]
    BJ = 24,

    [Display(Name = "Bermuda")] [Description("Bermuda")]
    BM = 25,

    [Display(Name = "Bhutan")] [Description("Bhutan")]
    BT = 26,

    [Display(Name = "Bolivia (Plurinational State of)")] [Description("Bolivia (Plurinational State of)")]
    BO = 27,

    [Display(Name = "Bonaire, Sint Eustatius and Saba")] [Description("Bonaire, Sint Eustatius and Saba")]
    BQ = 28,

    [Display(Name = "Bosnia and Herzegovina")] [Description("Bosnia and Herzegovina")]
    BA = 29,

    [Display(Name = "Botswana")] [Description("Botswana")]
    BW = 30,

    [Display(Name = "Bouvet Island")] [Description("Bouvet Island")]
    BV = 31,

    [Display(Name = "Brazil")] [Description("Brazil")]
    BR = 32,

    [Display(Name = "British Indian Ocean Territory")] [Description("British Indian Ocean Territory")]
    IO = 33,

    [Display(Name = "Brunei Darussalam")] [Description("Brunei Darussalam")]
    BN = 34,

    [Display(Name = "Bulgaria")] [Description("Bulgaria")]
    BG = 35,

    [Display(Name = "Burkina Faso")] [Description("Burkina Faso")]
    BF = 36,

    [Display(Name = "Burundi")] [Description("Burundi")]
    BI = 37,

    [Display(Name = "Cabo Verde")] [Description("Cabo Verde")]
    CV = 38,

    [Display(Name = "Cambodia")] [Description("Cambodia")]
    KH = 39,

    [Display(Name = "Cameroon")] [Description("Cameroon")]
    CM = 40,

    [Display(Name = "Canada")] [Description("Canada")]
    CA = 41,

    [Display(Name = "Cayman Islands")] [Description("Cayman Islands")]
    KY = 42,

    [Display(Name = "Central African Republic")] [Description("Central African Republic")]
    CF = 43,

    [Display(Name = "Chad")] [Description("Chad")]
    TD = 44,

    [Display(Name = "Chile")] [Description("Chile")]
    CL = 45,

    [Display(Name = "China")] [Description("China")]
    CN = 46,

    [Display(Name = "Christmas Island")] [Description("Christmas Island")]
    CX = 47,

    [Display(Name = "Cocos (Keeling) Islands")] [Description("Cocos (Keeling) Islands")]
    CC = 48,

    [Display(Name = "Colombia")] [Description("Colombia")]
    CO = 49,

    [Display(Name = "Comoros")] [Description("Comoros")]
    KM = 50,

    [Display(Name = "Congo")] [Description("Congo")]
    CG = 51,

    [Display(Name = "Congo (Democratic Republic of the)")] [Description("Congo (Democratic Republic of the)")]
    CD = 52,

    [Display(Name = "Cook Islands")] [Description("Cook Islands")]
    CK = 53,

    [Display(Name = "Costa Rica")] [Description("Costa Rica")]
    CR = 54,

    [Display(Name = "Côte d'Ivoire")] [Description("Côte d'Ivoire")]
    CI = 55,

    [Display(Name = "Croatia")] [Description("Croatia")]
    HR = 56,

    [Display(Name = "Cuba")] [Description("Cuba")]
    CU = 57,

    [Display(Name = "Curaçao")] [Description("Curaçao")]
    CW = 58,

    [Display(Name = "Cyprus")] [Description("Cyprus")]
    CY = 59,

    [Display(Name = "Czechia")] [Description("Czechia")]
    CZ = 60,

    [Display(Name = "Denmark")] [Description("Denmark")]
    DK = 61,

    [Display(Name = "Djibouti")] [Description("Djibouti")]
    DJ = 62,

    [Display(Name = "Dominica")] [Description("Dominica")]
    DM = 63,

    [Display(Name = "Dominican Republic")] [Description("Dominican Republic")]
    DO = 64,

    [Display(Name = "Ecuador")] [Description("Ecuador")]
    EC = 65,

    [Display(Name = "Egypt")] [Description("Egypt")]
    EG = 66,

    [Display(Name = "El Salvador")] [Description("El Salvador")]
    SV = 67,

    [Display(Name = "Equatorial Guinea")] [Description("Equatorial Guinea")]
    GQ = 68,

    [Display(Name = "Eritrea")] [Description("Eritrea")]
    ER = 69,

    [Display(Name = "Estonia")] [Description("Estonia")]
    EE = 70,

    [Display(Name = "Ethiopia")] [Description("Ethiopia")]
    ET = 71,

    [Display(Name = "Falkland Islands (Malvinas)")] [Description("Falkland Islands (Malvinas)")]
    FK = 72,

    [Display(Name = "Faroe Islands")] [Description("Faroe Islands")]
    FO = 73,

    [Display(Name = "Fiji")] [Description("Fiji")]
    FJ = 74,

    [Display(Name = "Finland")] [Description("Finland")]
    FI = 75,

    [Display(Name = "France")] [Description("France")]
    FR = 76,

    [Display(Name = "French Guiana")] [Description("French Guiana")]
    GF = 77,

    [Display(Name = "French Polynesia")] [Description("French Polynesia")]
    PF = 78,

    [Display(Name = "French Southern Territories")] [Description("French Southern Territories")]
    TF = 79,

    [Display(Name = "Gabon")] [Description("Gabon")]
    GA = 80,

    [Display(Name = "Gambia")] [Description("Gambia")]
    GM = 81,

    [Display(Name = "Georgia")] [Description("Georgia")]
    GE = 82,

    [Display(Name = "Germany")] [Description("Germany")]
    DE = 83,

    [Display(Name = "Ghana")] [Description("Ghana")]
    GH = 84,

    [Display(Name = "Gibraltar")] [Description("Gibraltar")]
    GI = 85,

    [Display(Name = "Greece")] [Description("Greece")]
    GR = 86,

    [Display(Name = "Greenland")] [Description("Greenland")]
    GL = 87,

    [Display(Name = "Grenada")] [Description("Grenada")]
    GD = 88,

    [Display(Name = "Guadeloupe")] [Description("Guadeloupe")]
    GP = 89,

    [Display(Name = "Guam")] [Description("Guam")]
    GU = 90,

    [Display(Name = "Guatemala")] [Description("Guatemala")]
    GT = 91,

    [Display(Name = "Guernsey")] [Description("Guernsey")]
    GG = 92,

    [Display(Name = "Guinea")] [Description("Guinea")]
    GN = 93,

    [Display(Name = "Guinea-Bissau")] [Description("Guinea-Bissau")]
    GW = 94,

    [Display(Name = "Guyana")] [Description("Guyana")]
    GY = 95,

    [Display(Name = "Haiti")] [Description("Haiti")]
    HT = 96,

    [Display(Name = "Heard Island and McDonald Islands")] [Description("Heard Island and McDonald Islands")]
    HM = 97,

    [Display(Name = "Holy See")] [Description("Holy See")]
    VA = 98,

    [Display(Name = "Honduras")] [Description("Honduras")]
    HN = 99,

    [Display(Name = "Hong Kong")] [Description("Hong Kong")]
    HK = 100,

    [Display(Name = "Hungary")] [Description("Hungary")]
    HU = 101,

    [Display(Name = "Iceland")] [Description("Iceland")]
    IS = 102,

    [Display(Name = "India")] [Description("India")]
    IN = 103,

    [Display(Name = "Indonesia")] [Description("Indonesia")]
    ID = 104,

    [Display(Name = "Iran (Islamic Republic of)")] [Description("Iran (Islamic Republic of)")]
    IR = 105,

    [Display(Name = "Iraq")] [Description("Iraq")]
    IQ = 106,

    [Display(Name = "Ireland")] [Description("Ireland")]
    IE = 107,

    [Display(Name = "Isle of Man")] [Description("Isle of Man")]
    IM = 108,

    [Display(Name = "Israel")] [Description("Israel")]
    IL = 109,

    [Display(Name = "Italy")] [Description("Italy")]
    IT = 110,

    [Display(Name = "Jamaica")] [Description("Jamaica")]
    JM = 111,

    [Display(Name = "Japan")] [Description("Japan")]
    JP = 112,

    [Display(Name = "Jersey")] [Description("Jersey")]
    JE = 113,

    [Display(Name = "Jordan")] [Description("Jordan")]
    JO = 114,

    [Display(Name = "Kazakhstan")] [Description("Kazakhstan")]
    KZ = 115,

    [Display(Name = "Kenya")] [Description("Kenya")]
    KE = 116,

    [Display(Name = "Kiribati")] [Description("Kiribati")]
    KI = 117,

    [Display(Name = "Korea (Democratic People's Republic of)")] [Description("Korea (Democratic People's Republic of)")]
    KP = 118,

    [Display(Name = "Korea (Republic of)")] [Description("Korea (Republic of)")]
    KR = 119,

    [Display(Name = "Kuwait")] [Description("Kuwait")]
    KW = 120,

    [Display(Name = "Kyrgyzstan")] [Description("Kyrgyzstan")]
    KG = 121,

    [Display(Name = "Lao People's Democratic Republic")] [Description("Lao People's Democratic Republic")]
    LA = 122,

    [Display(Name = "Latvia")] [Description("Latvia")]
    LV = 123,

    [Display(Name = "Lebanon")] [Description("Lebanon")]
    LB = 124,

    [Display(Name = "Lesotho")] [Description("Lesotho")]
    LS = 125,

    [Display(Name = "Liberia")] [Description("Liberia")]
    LR = 126,

    [Display(Name = "Libya")] [Description("Libya")]
    LY = 127,

    [Display(Name = "Liechtenstein")] [Description("Liechtenstein")]
    LI = 128,

    [Display(Name = "Lithuania")] [Description("Lithuania")]
    LT = 129,

    [Display(Name = "Luxembourg")] [Description("Luxembourg")]
    LU = 130,

    [Display(Name = "Macao")] [Description("Macao")]
    MO = 131,

    [Display(Name = "Macedonia (the former Yugoslav Republic of)")]
    [Description("Macedonia (the former Yugoslav Republic of)")]
    MK = 132,

    [Display(Name = "Madagascar")] [Description("Madagascar")]
    MG = 133,

    [Display(Name = "Malawi")] [Description("Malawi")]
    MW = 134,

    [Display(Name = "Malaysia")] [Description("Malaysia")]
    MY = 135,

    [Display(Name = "Maldives")] [Description("Maldives")]
    MV = 136,

    [Display(Name = "Mali")] [Description("Mali")]
    ML = 137,

    [Display(Name = "Malta")] [Description("Malta")]
    MT = 138,

    [Display(Name = "Marshall Islands")] [Description("Marshall Islands")]
    MH = 139,

    [Display(Name = "Martinique")] [Description("Martinique")]
    MQ = 140,

    [Display(Name = "Mauritania")] [Description("Mauritania")]
    MR = 141,

    [Display(Name = "Mauritius")] [Description("Mauritius")]
    MU = 142,

    [Display(Name = "Mayotte")] [Description("Mayotte")]
    YT = 143,

    [Display(Name = "Mexico")] [Description("Mexico")]
    MX = 144,

    [Display(Name = "Micronesia (Federated States of)")] [Description("Micronesia (Federated States of)")]
    FM = 145,

    [Display(Name = "Moldova (Republic of)")] [Description("Moldova (Republic of)")]
    MD = 146,

    [Display(Name = "Monaco")] [Description("Monaco")]
    MC = 147,

    [Display(Name = "Mongolia")] [Description("Mongolia")]
    MN = 148,

    [Display(Name = "Montenegro")] [Description("Montenegro")]
    ME = 149,

    [Display(Name = "Montserrat")] [Description("Montserrat")]
    MS = 150,

    [Display(Name = "Morocco")] [Description("Morocco")]
    MA = 151,

    [Display(Name = "Mozambique")] [Description("Mozambique")]
    MZ = 152,

    [Display(Name = "Myanmar")] [Description("Myanmar")]
    MM = 153,

    [Display(Name = "Namibia")] [Description("Namibia")]
    NA = 154,

    [Display(Name = "Nauru")] [Description("Nauru")]
    NR = 155,

    [Display(Name = "Nepal")] [Description("Nepal")]
    NP = 156,

    [Display(Name = "Netherlands")] [Description("Netherlands")]
    NL = 157,

    [Display(Name = "New Caledonia")] [Description("New Caledonia")]
    NC = 158,

    [Display(Name = "New Zealand")] [Description("New Zealand")]
    NZ = 159,

    [Display(Name = "Nicaragua")] [Description("Nicaragua")]
    NI = 160,

    [Display(Name = "Niger")] [Description("Niger")]
    NE = 161,

    [Display(Name = "Nigeria")] [Description("Nigeria")]
    NG = 162,

    [Display(Name = "Niue")] [Description("Niue")]
    NU = 163,

    [Display(Name = "Norfolk Island")] [Description("Norfolk Island")]
    NF = 164,

    [Display(Name = "Northern Mariana Islands")] [Description("Northern Mariana Islands")]
    MP = 165,

    [Display(Name = "Norway")] [Description("Norway")]
    NO = 166,

    [Display(Name = "Oman")] [Description("Oman")]
    OM = 167,

    [Display(Name = "Pakistan")] [Description("Pakistan")]
    PK = 168,

    [Display(Name = "Palau")] [Description("Palau")]
    PW = 169,

    [Display(Name = "Palestine, State of")] [Description("Palestine, State of")]
    PS = 170,

    [Display(Name = "Panama")] [Description("Panama")]
    PA = 171,

    [Display(Name = "Papua New Guinea")] [Description("Papua New Guinea")]
    PG = 172,

    [Display(Name = "Paraguay")] [Description("Paraguay")]
    PY = 173,

    [Display(Name = "Peru")] [Description("Peru")]
    PE = 174,

    [Display(Name = "Philippines")] [Description("Philippines")]
    PH = 175,

    [Display(Name = "Pitcairn")] [Description("Pitcairn")]
    PN = 176,

    [Display(Name = "Poland")] [Description("Poland")]
    PL = 177,

    [Display(Name = "Portugal")] [Description("Portugal")]
    PT = 178,

    [Display(Name = "Puerto Rico")] [Description("Puerto Rico")]
    PR = 179,

    [Display(Name = "Qatar")] [Description("Qatar")]
    QA = 180,

    [Display(Name = "Réunion")] [Description("Réunion")]
    RE = 181,

    [Display(Name = "Romania")] [Description("Romania")]
    RO = 182,

    [Display(Name = "Russian Federation")] [Description("Russian Federation")]
    RU = 183,

    [Display(Name = "Rwanda")] [Description("Rwanda")]
    RW = 184,

    [Display(Name = "Saint Barthélemy")] [Description("Saint Barthélemy")]
    BL = 185,

    [Display(Name = "Saint Helena, Ascension and Tristan da Cunha")]
    [Description("Saint Helena, Ascension and Tristan da Cunha")]
    SH = 186,

    [Display(Name = "Saint Kitts and Nevis")] [Description("Saint Kitts and Nevis")]
    KN = 187,

    [Display(Name = "Saint Lucia")] [Description("Saint Lucia")]
    LC = 188,

    [Display(Name = "Saint Martin (French part)")] [Description("Saint Martin (French part)")]
    MF = 189,

    [Display(Name = "Saint Pierre and Miquelon")] [Description("Saint Pierre and Miquelon")]
    PM = 190,

    [Display(Name = "Saint Vincent and the Grenadines")] [Description("Saint Vincent and the Grenadines")]
    VC = 191,

    [Display(Name = "Samoa")] [Description("Samoa")]
    WS = 192,

    [Display(Name = "San Marino")] [Description("San Marino")]
    SM = 193,

    [Display(Name = "Sao Tome and Principe")] [Description("Sao Tome and Principe")]
    ST = 194,

    [Display(Name = "Saudi Arabia")] [Description("Saudi Arabia")]
    SA = 195,

    [Display(Name = "Senegal")] [Description("Senegal")]
    SN = 196,

    [Display(Name = "Serbia")] [Description("Serbia")]
    RS = 197,

    [Display(Name = "Seychelles")] [Description("Seychelles")]
    SC = 198,

    [Display(Name = "Sierra Leone")] [Description("Sierra Leone")]
    SL = 199,

    [Display(Name = "Singapore")] [Description("Singapore")]
    SG = 200,

    [Display(Name = "Sint Maarten (Dutch part)")] [Description("Sint Maarten (Dutch part)")]
    SX = 201,

    [Display(Name = "Slovakia")] [Description("Slovakia")]
    SK = 202,

    [Display(Name = "Slovenia")] [Description("Slovenia")]
    SI = 203,

    [Display(Name = "Solomon Islands")] [Description("Solomon Islands")]
    SB = 204,

    [Display(Name = "Somalia")] [Description("Somalia")]
    SO = 205,

    [Display(Name = "South Africa")] [Description("South Africa")]
    ZA = 206,

    [Display(Name = "South Georgia and the South Sandwich Islands")]
    [Description("South Georgia and the South Sandwich Islands")]
    GS = 207,

    [Display(Name = "South Sudan")] [Description("South Sudan")]
    SS = 208,

    [Display(Name = "Spain")] [Description("Spain")]
    ES = 209,

    [Display(Name = "Sri Lanka")] [Description("Sri Lanka")]
    LK = 210,

    [Display(Name = "Sudan")] [Description("Sudan")]
    SD = 211,

    [Display(Name = "Suriname")] [Description("Suriname")]
    SR = 212,

    [Display(Name = "Svalbard and Jan Mayen")] [Description("Svalbard and Jan Mayen")]
    SJ = 213,

    [Display(Name = "Swaziland")] [Description("Swaziland")]
    SZ = 214,

    [Display(Name = "Sweden")] [Description("Sweden")]
    SE = 215,

    [Display(Name = "Switzerland")] [Description("Switzerland")]
    CH = 216,

    [Display(Name = "Syrian Arab Republic")] [Description("Syrian Arab Republic")]
    SY = 217,

    [Display(Name = "Taiwan, Province of China[a]")] [Description("Taiwan, Province of China[a]")]
    TW = 218,

    [Display(Name = "Tajikistan")] [Description("Tajikistan")]
    TJ = 219,

    [Display(Name = "Tanzania, United Republic of")] [Description("Tanzania, United Republic of")]
    TZ = 220,

    [Display(Name = "Thailand")] [Description("Thailand")]
    TH = 221,

    [Display(Name = "Timor-Leste")] [Description("Timor-Leste")]
    TL = 222,

    [Display(Name = "Togo")] [Description("Togo")]
    TG = 223,

    [Display(Name = "Tokelau")] [Description("Tokelau")]
    TK = 224,

    [Display(Name = "Tonga")] [Description("Tonga")]
    TO = 225,

    [Display(Name = "Trinidad and Tobago")] [Description("Trinidad and Tobago")]
    TT = 226,

    [Display(Name = "Tunisia")] [Description("Tunisia")]
    TN = 227,

    [Display(Name = "Turkey")] [Description("Turkey")]
    TR = 228,

    [Display(Name = "Turkmenistan")] [Description("Turkmenistan")]
    TM = 229,

    [Display(Name = "Turks and Caicos Islands")] [Description("Turks and Caicos Islands")]
    TC = 230,

    [Display(Name = "Tuvalu")] [Description("Tuvalu")]
    TV = 231,

    [Display(Name = "Uganda")] [Description("Uganda")]
    UG = 232,

    [Display(Name = "Ukraine")] [Description("Ukraine")]
    UA = 233,

    [Display(Name = "United Arab Emirates")] [Description("United Arab Emirates")]
    AE = 234,

    [Display(Name = "United Kingdom of Great Britain and Northern Ireland")]
    [Description("United Kingdom of Great Britain and Northern Ireland")]
    GB = 235,

    [Display(Name = "United States of America")] [Description("United States of America")]
    US = 236,

    [Display(Name = "United States Minor Outlying Islands")] [Description("United States Minor Outlying Islands")]
    UM = 237,

    [Display(Name = "Uruguay")] [Description("Uruguay")]
    UY = 238,

    [Display(Name = "Uzbekistan")] [Description("Uzbekistan")]
    UZ = 239,

    [Display(Name = "Vanuatu")] [Description("Vanuatu")]
    VU = 240,

    [Display(Name = "Venezuela (Bolivarian Republic of)")] [Description("Venezuela (Bolivarian Republic of)")]
    VE = 241,

    [Display(Name = "Viet Nam")] [Description("Viet Nam")]
    VN = 242,

    [Display(Name = "Virgin Islands (British)")] [Description("Virgin Islands (British)")]
    VG = 243,

    [Display(Name = "Virgin Islands (U.S.)")] [Description("Virgin Islands (U.S.)")]
    VI = 244,

    [Display(Name = "Wallis and Futuna")] [Description("Wallis and Futuna")]
    WF = 245,

    [Display(Name = "Western Sahara")] [Description("Western Sahara")]
    EH = 246,

    [Display(Name = "Yemen")] [Description("Yemen")]
    YE = 247,

    [Display(Name = "Zambia")] [Description("Zambia")]
    ZM = 248,

    [Display(Name = "Zimbabwe")] [Description("Zimbabwe")]
    ZW = 249
}
}
