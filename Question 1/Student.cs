namespace Question_1
{
    // Define a class Student, which contains the following information about 
    // students: full name, course, subject, university, e-mail and phone 
    // number.
    internal class Student
    {
        string FullName;

        string Course;

        Subject Subjects;

        University Universities;

        string Email;

        string PhoneNumber;
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