using Microsoft.EntityFrameworkCore;

namespace YourNamespaceHere
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<User>().HasData(
        new User
{
    Id = "c0b697ae-8b53-468b-9711-6bc146948547",
    EmployeeId = "u206813",
    FullName = "محمد حسين عبدالحميد منشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1031900341",
    Email = "MManshi@swcc.gov.sa",
    PhoneNumber = "(966) 548558455"
},
        new User
{
    Id = "b421f1d6-10c2-4063-b4e2-7930e886670c",
    EmployeeId = "u290702",
    FullName = "راشد سعد عبدالرحمن الحقباني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1073099853",
    Email = "RAlhaqbani@swcc.gov.sa",
    PhoneNumber = "(966) 500473399"
},
        new User
{
    Id = "41cfade3-15a7-4f3a-8a31-75279e928281",
    EmployeeId = "u290770",
    FullName = "توفيق شاعي دعيج ابن عميره",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1024408195",
    Email = "TBINOMIRA@swcc.gov.sa",
    PhoneNumber = "(966) 500022740"
},
        new User
{
    Id = "e5fed59b-f3ad-4d81-ad5f-7ed353830721",
    EmployeeId = "u290672",
    FullName = "حسن علي عبدالرحمن الشريف",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1032474056",
    Email = "HAlsharif3@swcc.gov.sa",
    PhoneNumber = "(966) 551115022"
},
        new User
{
    Id = "362450ca-ef44-46de-9413-196f9c0cd920",
    EmployeeId = "u205947",
    FullName = "احمد محمود سالم اشرم",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1012819338",
    Email = "aashram@swcc.gov.sa",
    PhoneNumber = "(966) 560007760"
},
        new User
{
    Id = "5b2c8dcd-e7f2-482e-8d29-6e20f73bc8e4",
    EmployeeId = "u203213",
    FullName = "محمد على مصطفى ابوعبا",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1057092742",
    Email = "mabuaba@swcc.gov.sa",
    PhoneNumber = "(966) 540940330"
},
        new User
{
    Id = "b9b1a958-1a55-4763-bdcb-dffa19e79836",
    EmployeeId = "u207821",
    FullName = "سامي عمر سالم باجابر",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1058754837",
    Email = "SBajaber@swcc.gov.sa",
    PhoneNumber = "(966) 592224444"
},
        new User
{
    Id = "60644dd5-e2b5-4d89-8a4a-8c2d8bd047e9",
    EmployeeId = "u206384",
    FullName = "يعقوب مسعود يماني العلوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1046693972",
    Email = "YAlalawi@swcc.gov.sa",
    PhoneNumber = "(966) 566606221"
},
        new User
{
    Id = "266dbcf7-84af-4d01-b624-c759323c84bb",
    EmployeeId = "u204453",
    FullName = "محمود رشيد صالح الخليدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1000197598",
    Email = "malkelydi@swcc.gov.sa",
    PhoneNumber = "(966) 555335504"
},
        new User
{
    Id = "6fe1d441-3fa8-4b8d-8977-907091d842dd",
    EmployeeId = "u206702",
    FullName = "عبدالرحمن غازي محمد الصيعري",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1069868311",
    Email = "Aalsayari@swcc.gov.sa",
    PhoneNumber = "(966) 599994951"
},
        new User
{
    Id = "f4c6f60e-7e2d-49ed-8bf1-6b9f901215df",
    EmployeeId = "u207209",
    FullName = "هشام عيسي محمدعلي المغربي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1031910381",
    Email = "HAlmaghrbi@swcc.gov.sa",
    PhoneNumber = "(966) 508307477"
},
        new User
{
    Id = "cb990cc4-f008-48db-a5a4-ff1020e061be",
    EmployeeId = "u205813",
    FullName = "رائد بن عبدالحميد بن عثمان السيد",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1065925198",
    Email = "ralsayed2@swcc.gov.sa",
    PhoneNumber = "(966) 504683656"
},
        new User
{
    Id = "b3e9bbf8-63e1-4b17-b40c-66257966d910",
    EmployeeId = "u207315",
    FullName = "محمد ابراهيم سليمان نجدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1076467669",
    Email = "MNajdi@swcc.gov.sa",
    PhoneNumber = "(966) 552828710"
},
        new User
{
    Id = "ff965d6c-4294-4b0a-962c-8ae2e122acd3",
    EmployeeId = "u204761",
    FullName = "علي عبدالله مسفر العرياني",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1002049516",
    Email = "aalaryani@swcc.gov.sa",
    PhoneNumber = "(966) 544714140"
},
        new User
{
    Id = "83dcdfae-9e02-4909-80d6-6bace8236633",
    EmployeeId = "u107686",
    FullName = "عمار سالم عمار القرشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1072505256",
    Email = "AAlqurashi3@swcc.gov.sa",
    PhoneNumber = "(966) 565738127"
},
        new User
{
    Id = "44a2f452-44f6-46e2-9c8f-28f339020cea",
    EmployeeId = "u206209",
    FullName = "محمد سعيد بكر باوجيه",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1026844777",
    Email = "mbawajeh@swcc.gov.sa",
    PhoneNumber = "(966) 569622679"
},
        new User
{
    Id = "e93c199c-b2be-4ec0-8b35-3abc2fcda1f7",
    EmployeeId = "u205055",
    FullName = "نايف عطيه الله دخيل الله الحربي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1010934121",
    Email = "nalharbi2@swcc.gov.sa",
    PhoneNumber = "(966) 544132454"
},
        new User
{
    Id = "a338089a-13b7-4aaf-ac4a-c6cb6244f6f4",
    EmployeeId = "u206216",
    FullName = "ريان حسن عبدالرحمن منشي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1016138768",
    Email = "Rmonshi@swcc.gov.sa",
    PhoneNumber = "(966) 566676869"
},
        new User
{
    Id = "951bdc57-6a62-4e53-bb08-cd7552b72b1b",
    EmployeeId = "u203162",
    FullName = "محمد ابن راجح ابن حامد العرابي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1053762371",
    Email = "MAlorabi@swcc.gov.sa",
    PhoneNumber = "(966) 555618890"
},
        new User
{
    Id = "79263fde-a849-4b2b-9d07-cc8e6b31584d",
    EmployeeId = "u204593",
    FullName = "خالد علي عبده خرشان",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1046591044",
    Email = "kkarshan@swcc.gov.sa",
    PhoneNumber = "(966) 593212425"
},
        new User
{
    Id = "c0035aa7-0ec2-40e5-b4a9-75ee78126d2c",
    EmployeeId = "u208025",
    FullName = "عماد حسن صالح حسن",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1016693473",
    Email = "EHassan2@swcc.gov.sa",
    PhoneNumber = "(966) 583030301"
},
        new User
{
    Id = "04a54a75-8009-4b46-bbcf-f793337efb67",
    EmployeeId = "u205288",
    FullName = "رامي فيصل بن صالح الأحمدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1033273457",
    Email = "ralahmedi@swcc.gov.sa",
    PhoneNumber = "(966) 505328024"
},
        new User
{
    Id = "ba503a28-e0fc-4a1b-936a-9f37f3881c43",
    EmployeeId = "u107678",
    FullName = "علي عبدالله علي الحربي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1074229020",
    Email = "AAlharbibf684@swcc.gov.sa",
    PhoneNumber = "(966) 504778823"
},
        new User
{
    Id = "95f4db42-aae8-4c1f-ad35-9e5831582e0d",
    EmployeeId = "u207816",
    FullName = "احمد عيسى علي مروحي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1108946664",
    Email = "AMurwahi@swcc.gov.sa",
    PhoneNumber = "(966) 596568871"
},
        new User
{
    Id = "012ef624-8e65-454d-81f4-d3fa529ef85a",
    EmployeeId = "u204634",
    FullName = "محمد بن ابراهيم بن محمدنور برناوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1013493851",
    Email = "MBrnawi@swcc.gov.sa",
    PhoneNumber = "(966) 554799198"
},
        new User
{
    Id = "9a0e391e-ac3a-435f-a7b3-49dcb0c88664",
    EmployeeId = "u106457",
    FullName = "علي هادي حسن معلم",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1006715120",
    Email = "AMuallim@swcc.gov.sa",
    PhoneNumber = "(966) 503692029"
},
        new User
{
    Id = "2a40798e-a96f-42ce-ae29-8794e60002a1",
    EmployeeId = "u204939",
    FullName = "اكرم بن صالح بن علي الصاعدي",
    JobTitle = "مفتش ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1053760987",
    Email = "AAlsaedi2@swcc.gov.sa",
    PhoneNumber = "(966) 548489106"
},
        new User
{
    Id = "d352572f-9a97-439b-88a7-99cd7776c36d",
    EmployeeId = "u207034",
    FullName = "علي عبدالله حسين محلاوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1063485427",
    Email = "AMahllawi@swcc.gov.sa",
    PhoneNumber = "(966) 568878874"
},
        new User
{
    Id = "d5018520-900f-47d1-9831-e2856ce22507",
    EmployeeId = "u290468",
    FullName = "عبدالمحسن بن محسن بن ظيف الله الشمري",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1023630575",
    Email = "AAlshammery6@swcc.gov.sa",
    PhoneNumber = "(966) 504225681"
},
        new User
{
    Id = "b724e6e8-8b82-4202-98ff-882647c67c25",
    EmployeeId = "u205807",
    FullName = "بدر فهد عبدالهادى الجهنى",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1067510105",
    Email = "BAl.Gehani@swcc.gov.sa",
    PhoneNumber = "(966) 542609622"
},
        new User
{
    Id = "2072808b-7007-489d-8d8a-1b902a4367a2",
    EmployeeId = "u107121",
    FullName = "سعد محمد صالح العبدالرحمن",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1071156804",
    Email = "SAl-Abdulrahman@swcc.gov.sa",
    PhoneNumber = "(966) 566641439"
},
        new User
{
    Id = "36420b72-04fd-462d-bb69-b2406aeb83d0",
    EmployeeId = "u106807",
    FullName = "مشاري ابراهيم رمضان الصالح",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1011767231",
    Email = "mal-saleh2@swcc.gov.sa",
    PhoneNumber = "(966) 595552353"
},
        new User
{
    Id = "95180db0-440d-4aa3-ba8b-f591c51164de",
    EmployeeId = "u107729",
    FullName = "محمد سعود حمد الشهراني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1071882573",
    Email = "MAlshahrani3507b0@swcc.gov.sa",
    PhoneNumber = "(966) 509880885"
},
        new User
{
    Id = "72a5e075-32ed-4108-8b60-1579fc99ee6f",
    EmployeeId = "u108687",
    FullName = "عبدالله بن مثال بن مطلق الصهيبي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1059172773",
    Email = "AAl-Sauhaibi@swcc.gov.sa",
    PhoneNumber = "(966) 555952333"
},
        new User
{
    Id = "e9340dac-7014-4f00-b15e-ae1f26eb4ca4",
    EmployeeId = "u106141",
    FullName = "يحيى محمد علي الخميسي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1072269903",
    Email = "YAlKhamisi@swcc.gov.sa",
    PhoneNumber = "(966) 553671467"
},
        new User
{
    Id = "e85e3998-4a74-4c65-96fb-c094a643f4b8",
    EmployeeId = "u108199",
    FullName = "عبدالله علي عويضه السعيدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1077868816",
    Email = "AAlsaeedi@swcc.gov.sa",
    PhoneNumber = "(966) 532043936"
},
        new User
{
    Id = "f209326a-c50a-4a9e-9ae4-5b3eab748eea",
    EmployeeId = "u290681",
    FullName = "جراح محارب حركان العنزي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1030306938",
    Email = "JAlanezi@swcc.gov.sa",
    PhoneNumber = "(966) 532223778"
},
        new User
{
    Id = "0639f4f5-a470-43fe-ba80-a68a1be68d02",
    EmployeeId = "u290706",
    FullName = "عبدالعزيز محمد ابراهيم السويلم",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1033887512",
    Email = "AAlswailem@swcc.gov.sa",
    PhoneNumber = "(966) 538444426"
},
        new User
{
    Id = "db9ca9d3-2621-4bb8-9d46-33de744ea8bf",
    EmployeeId = "u107135",
    FullName = "عبدالرحمن مجدي بن عبدالحميد يغمور",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1068682440",
    Email = "AYaghmoor@swcc.gov.sa",
    PhoneNumber = "(966) 541616166"
},
        new User
{
    Id = "1834bed2-0e43-45b3-8527-212c0e89895f",
    EmployeeId = "u108964",
    FullName = "اسامه جابر سالم الدوسري",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1086693668",
    Email = "OAlDossari@swcc.gov.sa",
    PhoneNumber = "(966) 539092990"
},
        new User
{
    Id = "b345ea6b-d483-4c3f-8d51-84794fefae55",
    EmployeeId = "u107025",
    FullName = "محمد مهدي بن عباس الصادق",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1063078800",
    Email = "MAl-Sadiq@swcc.gov.sa",
    PhoneNumber = "(966) 508987893"
},
        new User
{
    Id = "666f48c4-2c5d-4917-aa6d-94c529be991f",
    EmployeeId = "u108878",
    FullName = "عبدالله سمير حسين مالكي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1084849494",
    Email = "amalki3@swcc.gov.sa",
    PhoneNumber = "(966) 507704757"
},
        new User
{
    Id = "e1c94309-0936-4605-881a-5ff1624c8557",
    EmployeeId = "u105439",
    FullName = "محمد بن ضيف الله بن حسن ال ماشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1025297233",
    Email = "MAlmashi@swcc.gov.sa",
    PhoneNumber = "(966) 534095593"
},
        new User
{
    Id = "e9a696c4-ee7d-454d-8f3e-b0732f07008e",
    EmployeeId = "u108129",
    FullName = "عمر جمعان ابن عبدالله الغامدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1082422690",
    Email = "OAlghamdi7@swcc.gov.sa",
    PhoneNumber = "(966) 531399068"
},
        new User
{
    Id = "a37666c5-b51a-445a-8867-24965a3f59d8",
    EmployeeId = "u107205",
    FullName = "احمد حماد محمدعلي الصحفي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1072543521",
    Email = "AALSAHAFI@swcc.gov.sa",
    PhoneNumber = "(966) 561273692"
},
        new User
{
    Id = "97892974-3066-4242-b96b-e6e1c5cf5086",
    EmployeeId = "u108683",
    FullName = "عبدالاله محمد بن عبدالحميد الغامدى",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1070445331",
    Email = "AAlghamdi2988c@swcc.gov.sa",
    PhoneNumber = "(966) 558858085"
},
        new User
{
    Id = "076728c5-4a9f-4c52-9ae1-50bc5c3dee9b",
    EmployeeId = "u107607",
    FullName = "عبدالرحمن سعد بن عيد الوسمي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1073971911",
    Email = "AAlwasmi@swcc.gov.sa",
    PhoneNumber = "(966) 557724513"
},
        new User
{
    Id = "d32eb359-1f7a-4b59-aa27-2b40ef7ac401",
    EmployeeId = "u107770",
    FullName = "معتصم مختار عبدالوهاب الهوساوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1074919885",
    Email = "MAlhawsaei@swcc.gov.sa",
    PhoneNumber = "(966) 564297996"
},
        new User
{
    Id = "3678e8b1-f3fe-4534-84b2-d87748f6d2f3",
    EmployeeId = "u107555",
    FullName = "محمد سالم محمد شكر",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1055517914",
    Email = "Mshukor@swcc.gov.sa",
    PhoneNumber = "(966) 566911632"
},
        new User
{
    Id = "026508e8-9ba3-4808-a222-10917c105f42",
    EmployeeId = "u107375",
    FullName = "تركي خليل مبارك السويلم",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1060426432",
    Email = "TALSWAILEM@swcc.gov.sa",
    PhoneNumber = "(966) 558011417"
},
        new User
{
    Id = "ed11592b-878d-40a6-8e71-bb1ab1967106",
    EmployeeId = "u206942",
    FullName = "مشعل جعفر علي القطان",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1044757175",
    Email = "malqattan@swcc.gov.sa",
    PhoneNumber = "(966) 554389507"
},
        new User
{
    Id = "f5508b1a-bb2a-4490-b6de-e1f40774d2da",
    EmployeeId = "u104912",
    FullName = "عبدالله بن عرابي بن أحمد الزهراني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1022249195",
    Email = "AAl-Zahrani4@swcc.gov.sa",
    PhoneNumber = "(966) 561686556"
},
        new User
{
    Id = "ee00478f-a133-45a1-9a16-e5ce8882f3a8",
    EmployeeId = "u290897",
    FullName = "محمد محمود تمراز",
    JobTitle = "أخصائي متابعة الأداء والرقابة",
    ExecutiveDepartment = "الفرع الرئيسي بالهيئة السعودية للمياه",
    NationalId = "1037689815",
    Email = "mtimraz3@swcc.gov.sa",
    PhoneNumber = "591537351"
},
        new User
{
    Id = "86705279-0b29-4f60-a5b4-92ea2e4d91bd",
    EmployeeId = "u292232",
    FullName = "مشعل علي المنيع",
    JobTitle = "المشرف العام للإدارة التنفيذية للرقابة والتراخيص",
    ExecutiveDepartment = "الفرع الرئيسي بالهيئة السعودية للمياه",
    NationalId = "1007927237",
    Email = "MAlmanie@swa.gov.sa",
    PhoneNumber = "551333565"
}
    );
}
    }

    public class User
    {
        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string ExecutiveDepartment { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}