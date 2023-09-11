namespace Question_2
{
    // Declare several constructors for the class Student, which have different 
    // lists of parameters (for complete information about a student or part of 
    // it). Data, which has no initial value to be initialized with null. Use 
    // nullable types for all non-mandatory data.

    internal class Student
    {
        string fullName;

        string course;

        Subject subjects;

        University universities;

        string email;

        string phoneNumber;
        
        internal Student() 
        {
    
        }
        internal Student(string fullName) 
        {
            this.fullName = fullName;
        }
        internal Student(string fullName, string course) 
        {
            this.fullName = fullName;
            this.course = course;
        }
        internal Student(string fullName, string course, Subject subjects) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
        }
        internal Student(string fullName, string course, Subject subjects, University universities) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
        }
        internal Student(string fullName, string course, Subject subjects, University universities, string email) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
            this.email = email;
        }
        internal Student(string fullName, string course, Subject subjects, University universities, string email, string phoneNumber) 
        {
            this.fullName = fullName;
            this.course = course;
            this.subjects = subjects;
            this.universities = universities;
            this.email = email;
            this.phoneNumber = phoneNumber;
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