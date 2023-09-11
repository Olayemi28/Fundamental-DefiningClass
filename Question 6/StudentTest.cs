using System;
using System.Collections.Generic;

namespace Question_6
{
    internal class StudentTest
    {
        internal void CreateStudent()
        {
            List<Student> studentList = new List<Student>();
            Student student1 = new Student();
            Student student2 = new Student("Adebayo Salami");
            Student student3 = new Student("Bisola Aiyeola", "Medicine");
            Student student4 = new Student("Bimbo Ademoye", "Mechanical Engineering", Subject.Mathematics,Subject.EnglishLanguage, Subject.Physics);
            Student student5 = new Student("Ayeloja Orunnile","Pharmacy", University.ABU ,Subject.Account, Subject.Biology, Subject.CivicEducation, Subject.Chemistry);
            Student student6 = new Student("Adesuwa Etomi", "Linguitics", University.BABCOCK, "adesuwaetomi@gmail.com", Subject.Government, Subject.History, Subject.Biology);
            Student student7 = new Student("Daniel Etim", "Theater&Art", University.OAU, "danieleffiong@gmail.com", "09087654321", Subject.Government, Subject.LiteratureInEnglish, Subject.EnglishLanguage);

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);
            studentList.Add(student6);
            studentList.Add(student7);
            studentList.ForEach(list => Console.WriteLine(list.ToString()));
        }

    }
}