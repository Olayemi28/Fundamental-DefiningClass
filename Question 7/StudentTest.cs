using System;
using System.Collections.Generic;

namespace Question_7
{
    internal class StudentTest
    {
       internal static void CreateStudent()
       {
            List<string> studentList = new List<string>();
            Student student1 = new Student();
            Console.WriteLine(student1.ToString() + "\n");

            Student student2 = new Student("Efa Iwara");
            Console.WriteLine(student2.ToString() + "\n");

            Student student3 = new Student("Rebecca Hampson", "Linguitics");
            Console.WriteLine(student3.ToString() + "\n");

            Student student4 = new Student("Timini Egbuson", "Physiology", Subject.Chemistry, Subject.EnglishLanguage, Subject.Mathematics, Subject.Physics, Subject.Biology);
            Console.WriteLine(student4.ToString() + "\n");

            Student student5 = new Student("Chineye Nnebe", "Cosmetology", University.LASU, Subject.LiteratureInEnglish, Subject.EnglishLanguage, Subject.Government, Subject.Economics, Subject.Biology);
            Console.WriteLine(student5.ToString() + "\n");

            Student student6 = new Student("Daniel Etim", "Cinematography", University.UNILAG, "danieleffiong@gmail.com", Subject.LiteratureInEnglish, Subject.EnglishLanguage, Subject.Government, Subject.Economics, Subject.History);
            Console.WriteLine(student6.ToString() + "\n");

            Student student7 = new Student("Uche Montana", "Threatre & Art", University.CONVENANT, "uchemontana@gmail.com", "09087654321", Subject.LiteratureInEnglish, Subject.EnglishLanguage, Subject.Government, Subject.Economics, Subject.ChristainReligiousStudies);
            Console.WriteLine(student7.ToString() + "\n");

            /*studentList.Add(student1.ToString());
            studentList.Add(student2.ToString());
            studentList.Add(student3.ToString());*
            studentList.Add(student4.ToString());
            studentList.Add(student5.ToString());
            studentList.Add(student6.ToString());
            studentList.Add(student7.ToString());*/
            //studentList.ForEach(student => Console.WriteLine(student + "\n"));
       }
    }
}