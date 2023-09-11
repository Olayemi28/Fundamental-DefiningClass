using System;
using System.Collections.Generic;

namespace Question_4
{
    // Add a method in the class Student, which displays complete information 
    // about the student.
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
    
        internal void PrintStudentInfo()
        {
            List<string> save = new List<string>();
            Student student = new Student();
            int count = 1;
            
            Console.Write("Enter your fullname: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter the number of subject to offer:");
            int length;
            while (!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a correct input:");
            }

            foreach (var item in Enum.GetNames(typeof(Subject)))
            {
                Console.WriteLine($"{count} = {item}");
                count++;
            }

            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Select your subject [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Subject subject;
            foreach (var item in array)
            {
                subject = (Subject)Enum.ToObject(typeof(Subject), item);
                save.Add(subject.ToString());
            }

            Console.WriteLine("Select your university: ");
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(University)))
            {
                Console.WriteLine($"{counter} = {item}");
                counter++;
            }
            int university = int.Parse(Console.ReadLine());
            University university1 = (University)Enum.ToObject(typeof(University), university);

            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("\n\n");

            Console.WriteLine($"FullName:{fullName}\n" +
                $"\nCourse:{courseName}\n");
            Console.Write("Subjects: ");
            Console.WriteLine(string.Join(",", save));
            Console.WriteLine($"\nUniversity:{university1}\n" +
                $"\nE-mail Address:{email}\n" +
                $"\nPhone Number:{phoneNumber}");

            Console.WriteLine("\n\n");
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