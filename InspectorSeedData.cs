using Microsoft.EntityFrameworkCore;

namespace YourNamespaceHere
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Inspector> Inspectors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Inspector>().HasData(
        new Inspector
{
    EmployeeId = "u206813",
    FullName = "محمد حسين عبدالحميد منشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1031900341",
    Email = "MManshi@swcc.gov.sa",
    PhoneNumber = "(966) 548558455"
},
        new Inspector
{
    EmployeeId = "u290702",
    FullName = "راشد سعد عبدالرحمن الحقباني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1073099853",
    Email = "RAlhaqbani@swcc.gov.sa",
    PhoneNumber = "(966) 500473399"
},
        new Inspector
{
    EmployeeId = "u290770",
    FullName = "توفيق شاعي دعيج ابن عميره",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1024408195",
    Email = "TBINOMIRA@swcc.gov.sa",
    PhoneNumber = "(966) 500022740"
},
        new Inspector
{
    EmployeeId = "u290672",
    FullName = "حسن علي عبدالرحمن الشريف",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1032474056",
    Email = "HAlsharif3@swcc.gov.sa",
    PhoneNumber = "(966) 551115022"
},
        new Inspector
{
    EmployeeId = "u205947",
    FullName = "احمد محمود سالم اشرم",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1012819338",
    Email = "aashram@swcc.gov.sa",
    PhoneNumber = "(966) 560007760"
},
        new Inspector
{
    EmployeeId = "u203213",
    FullName = "محمد على مصطفى ابوعبا",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1057092742",
    Email = "mabuaba@swcc.gov.sa",
    PhoneNumber = "(966) 540940330"
},
        new Inspector
{
    EmployeeId = "u207821",
    FullName = "سامي عمر سالم باجابر",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1058754837",
    Email = "SBajaber@swcc.gov.sa",
    PhoneNumber = "(966) 592224444"
},
        new Inspector
{
    EmployeeId = "u206384",
    FullName = "يعقوب مسعود يماني العلوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1046693972",
    Email = "YAlalawi@swcc.gov.sa",
    PhoneNumber = "(966) 566606221"
},
        new Inspector
{
    EmployeeId = "u204453",
    FullName = "محمود رشيد صالح الخليدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1000197598",
    Email = "malkelydi@swcc.gov.sa",
    PhoneNumber = "(966) 555335504"
},
        new Inspector
{
    EmployeeId = "u206702",
    FullName = "عبدالرحمن غازي محمد الصيعري",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1069868311",
    Email = "Aalsayari@swcc.gov.sa",
    PhoneNumber = "(966) 599994951"
},
        new Inspector
{
    EmployeeId = "u207209",
    FullName = "هشام عيسي محمدعلي المغربي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1031910381",
    Email = "HAlmaghrbi@swcc.gov.sa",
    PhoneNumber = "(966) 508307477"
},
        new Inspector
{
    EmployeeId = "u205813",
    FullName = "رائد بن عبدالحميد بن عثمان السيد",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1065925198",
    Email = "ralsayed2@swcc.gov.sa",
    PhoneNumber = "(966) 504683656"
},
        new Inspector
{
    EmployeeId = "u207315",
    FullName = "محمد ابراهيم سليمان نجدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1076467669",
    Email = "MNajdi@swcc.gov.sa",
    PhoneNumber = "(966) 552828710"
},
        new Inspector
{
    EmployeeId = "u204761",
    FullName = "علي عبدالله مسفر العرياني",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1002049516",
    Email = "aalaryani@swcc.gov.sa",
    PhoneNumber = "(966) 544714140"
},
        new Inspector
{
    EmployeeId = "u107686",
    FullName = "عمار سالم عمار القرشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1072505256",
    Email = "AAlqurashi3@swcc.gov.sa",
    PhoneNumber = "(966) 565738127"
},
        new Inspector
{
    EmployeeId = "u206209",
    FullName = "محمد سعيد بكر باوجيه",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1026844777",
    Email = "mbawajeh@swcc.gov.sa",
    PhoneNumber = "(966) 569622679"
},
        new Inspector
{
    EmployeeId = "u205055",
    FullName = "نايف عطيه الله دخيل الله الحربي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1010934121",
    Email = "nalharbi2@swcc.gov.sa",
    PhoneNumber = "(966) 544132454"
},
        new Inspector
{
    EmployeeId = "u206216",
    FullName = "ريان حسن عبدالرحمن منشي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1016138768",
    Email = "Rmonshi@swcc.gov.sa",
    PhoneNumber = "(966) 566676869"
},
        new Inspector
{
    EmployeeId = "u203162",
    FullName = "محمد ابن راجح ابن حامد العرابي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1053762371",
    Email = "MAlorabi@swcc.gov.sa",
    PhoneNumber = "(966) 555618890"
},
        new Inspector
{
    EmployeeId = "u204593",
    FullName = "خالد علي عبده خرشان",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1046591044",
    Email = "kkarshan@swcc.gov.sa",
    PhoneNumber = "(966) 593212425"
},
        new Inspector
{
    EmployeeId = "u208025",
    FullName = "عماد حسن صالح حسن",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1016693473",
    Email = "EHassan2@swcc.gov.sa",
    PhoneNumber = "(966) 583030301"
},
        new Inspector
{
    EmployeeId = "u205288",
    FullName = "رامي فيصل بن صالح الأحمدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1033273457",
    Email = "ralahmedi@swcc.gov.sa",
    PhoneNumber = "(966) 505328024"
},
        new Inspector
{
    EmployeeId = "u107678",
    FullName = "علي عبدالله علي الحربي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1074229020",
    Email = "AAlharbibf684@swcc.gov.sa",
    PhoneNumber = "(966) 504778823"
},
        new Inspector
{
    EmployeeId = "u207816",
    FullName = "احمد عيسى علي مروحي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1108946664",
    Email = "AMurwahi@swcc.gov.sa",
    PhoneNumber = "(966) 596568871"
},
        new Inspector
{
    EmployeeId = "u204634",
    FullName = "محمد بن ابراهيم بن محمدنور برناوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1013493851",
    Email = "MBrnawi@swcc.gov.sa",
    PhoneNumber = "(966) 554799198"
},
        new Inspector
{
    EmployeeId = "u106457",
    FullName = "علي هادي حسن معلم",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1006715120",
    Email = "AMuallim@swcc.gov.sa",
    PhoneNumber = "(966) 503692029"
},
        new Inspector
{
    EmployeeId = "u204939",
    FullName = "اكرم بن صالح بن علي الصاعدي",
    JobTitle = "مفتش ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1053760987",
    Email = "AAlsaedi2@swcc.gov.sa",
    PhoneNumber = "(966) 548489106"
},
        new Inspector
{
    EmployeeId = "u207034",
    FullName = "علي عبدالله حسين محلاوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1063485427",
    Email = "AMahllawi@swcc.gov.sa",
    PhoneNumber = "(966) 568878874"
},
        new Inspector
{
    EmployeeId = "u290468",
    FullName = "عبدالمحسن بن محسن بن ظيف الله الشمري",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1023630575",
    Email = "AAlshammery6@swcc.gov.sa",
    PhoneNumber = "(966) 504225681"
},
        new Inspector
{
    EmployeeId = "u205807",
    FullName = "بدر فهد عبدالهادى الجهنى",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1067510105",
    Email = "BAl.Gehani@swcc.gov.sa",
    PhoneNumber = "(966) 542609622"
},
        new Inspector
{
    EmployeeId = "u107121",
    FullName = "سعد محمد صالح العبدالرحمن",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1071156804",
    Email = "SAl-Abdulrahman@swcc.gov.sa",
    PhoneNumber = "(966) 566641439"
},
        new Inspector
{
    EmployeeId = "u106807",
    FullName = "مشاري ابراهيم رمضان الصالح",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1011767231",
    Email = "mal-saleh2@swcc.gov.sa",
    PhoneNumber = "(966) 595552353"
},
        new Inspector
{
    EmployeeId = "u107729",
    FullName = "محمد سعود حمد الشهراني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1071882573",
    Email = "MAlshahrani3507b0@swcc.gov.sa",
    PhoneNumber = "(966) 509880885"
},
        new Inspector
{
    EmployeeId = "u108687",
    FullName = "عبدالله بن مثال بن مطلق الصهيبي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1059172773",
    Email = "AAl-Sauhaibi@swcc.gov.sa",
    PhoneNumber = "(966) 555952333"
},
        new Inspector
{
    EmployeeId = "u106141",
    FullName = "يحيى محمد علي الخميسي",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1072269903",
    Email = "YAlKhamisi@swcc.gov.sa",
    PhoneNumber = "(966) 553671467"
},
        new Inspector
{
    EmployeeId = "u108199",
    FullName = "عبدالله علي عويضه السعيدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1077868816",
    Email = "AAlsaeedi@swcc.gov.sa",
    PhoneNumber = "(966) 532043936"
},
        new Inspector
{
    EmployeeId = "u290681",
    FullName = "جراح محارب حركان العنزي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1030306938",
    Email = "JAlanezi@swcc.gov.sa",
    PhoneNumber = "(966) 532223778"
},
        new Inspector
{
    EmployeeId = "u290706",
    FullName = "عبدالعزيز محمد ابراهيم السويلم",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1033887512",
    Email = "AAlswailem@swcc.gov.sa",
    PhoneNumber = "(966) 538444426"
},
        new Inspector
{
    EmployeeId = "u107135",
    FullName = "عبدالرحمن مجدي بن عبدالحميد يغمور",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1068682440",
    Email = "AYaghmoor@swcc.gov.sa",
    PhoneNumber = "(966) 541616166"
},
        new Inspector
{
    EmployeeId = "u108964",
    FullName = "اسامه جابر سالم الدوسري",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1086693668",
    Email = "OAlDossari@swcc.gov.sa",
    PhoneNumber = "(966) 539092990"
},
        new Inspector
{
    EmployeeId = "u107025",
    FullName = "محمد مهدي بن عباس الصادق",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1063078800",
    Email = "MAl-Sadiq@swcc.gov.sa",
    PhoneNumber = "(966) 508987893"
},
        new Inspector
{
    EmployeeId = "u108878",
    FullName = "عبدالله سمير حسين مالكي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1084849494",
    Email = "amalki3@swcc.gov.sa",
    PhoneNumber = "(966) 507704757"
},
        new Inspector
{
    EmployeeId = "u105439",
    FullName = "محمد بن ضيف الله بن حسن ال ماشي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1025297233",
    Email = "MAlmashi@swcc.gov.sa",
    PhoneNumber = "(966) 534095593"
},
        new Inspector
{
    EmployeeId = "u108129",
    FullName = "عمر جمعان ابن عبدالله الغامدي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1082422690",
    Email = "OAlghamdi7@swcc.gov.sa",
    PhoneNumber = "(966) 531399068"
},
        new Inspector
{
    EmployeeId = "u107205",
    FullName = "احمد حماد محمدعلي الصحفي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1072543521",
    Email = "AALSAHAFI@swcc.gov.sa",
    PhoneNumber = "(966) 561273692"
},
        new Inspector
{
    EmployeeId = "u108683",
    FullName = "عبدالاله محمد بن عبدالحميد الغامدى",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1070445331",
    Email = "AAlghamdi2988c@swcc.gov.sa",
    PhoneNumber = "(966) 558858085"
},
        new Inspector
{
    EmployeeId = "u107607",
    FullName = "عبدالرحمن سعد بن عيد الوسمي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1073971911",
    Email = "AAlwasmi@swcc.gov.sa",
    PhoneNumber = "(966) 557724513"
},
        new Inspector
{
    EmployeeId = "u107770",
    FullName = "معتصم مختار عبدالوهاب الهوساوي",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1074919885",
    Email = "MAlhawsaei@swcc.gov.sa",
    PhoneNumber = "(966) 564297996"
},
        new Inspector
{
    EmployeeId = "u107555",
    FullName = "محمد سالم محمد شكر",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1055517914",
    Email = "Mshukor@swcc.gov.sa",
    PhoneNumber = "(966) 566911632"
},
        new Inspector
{
    EmployeeId = "u107375",
    FullName = "تركي خليل مبارك السويلم",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة الرياض",
    NationalId = "1060426432",
    Email = "TALSWAILEM@swcc.gov.sa",
    PhoneNumber = "(966) 558011417"
},
        new Inspector
{
    EmployeeId = "u206942",
    FullName = "مشعل جعفر علي القطان",
    JobTitle = "مفتش رئيسي ميداني",
    ExecutiveDepartment = "فرع الهيئة بالمنطقة الشرقية",
    NationalId = "1044757175",
    Email = "malqattan@swcc.gov.sa",
    PhoneNumber = "(966) 554389507"
},
        new Inspector
{
    EmployeeId = "u104912",
    FullName = "عبدالله بن عرابي بن أحمد الزهراني",
    JobTitle = "مفتش أول ميداني",
    ExecutiveDepartment = "فرع الهيئة بمنطقة مكة المكرمة",
    NationalId = "1022249195",
    Email = "AAl-Zahrani4@swcc.gov.sa",
    PhoneNumber = "(966) 561686556"
},
        new Inspector
{
    EmployeeId = "u290897",
    FullName = "محمد محمود تمراز",
    JobTitle = "أخصائي متابعة الأداء والرقابة",
    ExecutiveDepartment = "الفرع الرئيسي بالهيئة السعودية للمياه",
    NationalId = "1037689815",
    Email = "mtimraz3@swcc.gov.sa",
    PhoneNumber = "591537351"
},
        new Inspector
{
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

    public class Inspector
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string ExecutiveDepartment { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}