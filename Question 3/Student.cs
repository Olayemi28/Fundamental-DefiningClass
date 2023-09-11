namespace Question_3
{
    // Add a static field for the class Student, which holds the number of 
    // created objects of this class.
    internal class Student
    {
        string fullName;

        string course;

        Subject subjects;

        University universities;

        string email;

        string phoneNumber;

        static int studentCount;

        internal Student() 
        {
            studentCount++;
        }
        internal Student(string fullName) 
        {
            this.fullName = fullName;
            studentCount++;
        }
        internal Student(string fullName, string course) 
        {
            this.fullName = fullName;
            this.course = course;
            studentCount++;
        }
        internal Student(string fullName, string course, Subject subjects) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            studentCount++;
        }
        internal Student(string fullName, string course, Subject subjects, University universities) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
            studentCount++;
        }
        internal Student(string fullName, string course, Subject subjects, University universities, string email) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
            this.email = email;
            studentCount++;
        }
        internal Student(string fullName, string course, Subject subjects, University universities, string email, string phoneNumber) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
            this.email = email;
            this.phoneNumber = phoneNumber;
            studentCount++;

        }
    }

    enum Subject
    {
        Mathematics = 1,
        EnglishLanguage,
        Physics,
        Biology,
        Chemistry,
        Commerce,
        Account,
        Government,
        LiteratureInEnglish,
        Economics,
        FurtherMathematics,
        YorubaLanguage,
        AgriculturalScience,
        AnimalHusbandry,
        Fishery,
        FoodAndNutrition,
        CateringAndCraft,
        CivicEducation,
        Marketing,
        ChristainReligiousStudies,
        IslamicReligiousStudies,
        History,
        ComputerStudies
    }

    enum University
    {
        FUNAAB = 1,
        OAU,
        FUTA,
        FUOYE,
        UNILORIN,
        UNILAG,
        UNIBEN,
        BOWEN,
        CONVENANT,
        LEADCITY,
        CALEB,
        BUK,
        ABU,
        UI,
        BABCOCK,
        OOU,
        REDEEMERS,
        ADELEKE,
        LAUTECH,
        UNIOSUN,
        FOUNTAIN,
        ALHIKMAH,
        MINARET,
        LASU,
        TAISOLARIN
    }
}