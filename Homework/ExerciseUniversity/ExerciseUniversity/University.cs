using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseUniversity
{
    class University
    {
        public List<Course> Mathimata;
        public List<Student> Ma8htes;

        public bool[,] IsRegistered;
        public double[,] Grades;
        public double[,] CompCourse;

        public University()
        {
            Mathimata = new List<Course>();
            Mathimata.Add(new Course("MAth", 4));
            Mathimata.Add(new Course("Physics", 5));
            Mathimata.Add(new Course("Chemistry", 5));
            Mathimata.Add(new Course("Greek", 3));
            Mathimata.Add(new Course("English", 3));
            Mathimata.Add(new Course("Algebra", 5));
            Mathimata.Add(new Course("Geometry", 4));
            Mathimata.Add(new Course("Italian", 3));
            Mathimata.Add(new Course("History", 5));
            Mathimata.Add(new Course("Gymnastics", 4));
            Mathimata.Add(new Course("French", 3));
            Mathimata.Add(new Course("Informatics", 5));

            Ma8htes = new List<Student>();
            Ma8htes.Add(new Student("Papadopoulos"));
            Ma8htes.Add(new Student("Pappas"));
            Ma8htes.Add(new Student("Koliabasilhs"));
            Ma8htes.Add(new Student("Prapas"));
            Ma8htes.Add(new Student("Topsidis"));
            Ma8htes.Add(new Student("Kantounis"));
            Ma8htes.Add(new Student("Margariths"));
            Ma8htes.Add(new Student("Babalis"));
            Ma8htes.Add(new Student("Petrakis"));
            Ma8htes.Add(new Student("Perrakis"));
            Ma8htes.Add(new Student("Kretshs"));


            IsRegistered = new bool[Ma8htes.Count, Mathimata.Count];
            Grades = new double[Ma8htes.Count, Mathimata.Count];
            CompCourse = new double[Ma8htes.Count, Mathimata.Count];

            for (int i = 0; i < Ma8htes.Count; i++)
            {
                for (int j = 0; j < Mathimata.Count; j++)
                {
                    IsRegistered[i, j] = false;
                    Grades[i, j] = 0.0;
                    CompCourse[i, j] = 0.0;
                }
            }
        }

        public void RegisterToCourse(Student ma8hths, Course ma8hma)
        {
            for (int i=0; i < Ma8htes.Count; i++)
            {
                for (int j = 0; j < Mathimata.Count; j++)
                {
                    if (Ma8htes[i] == ma8hths && Mathimata[j] == ma8hma && IsRegistered[i, j] == false)
                    {
                        IsRegistered[i, j] = true;
                    }
                }
            }
        }

        public void CourseGrage(Student ma8hths, Course ma8hma, double grade)
        {
            for (int i = 0; i < Ma8htes.Count; i++)
            {
                for (int j = 0; j < Mathimata.Count; j++)
                {
                    if (Ma8htes[i] == ma8hths && Mathimata[j] == ma8hma && IsRegistered[i, j] == true)
                    {
                        Grades[i,j] = grade;
                    }
                }
            }
        }

        public bool IsReachedLimit(Student ma8hths)
        {
            int idx = 0;
            int position = Ma8htes.IndexOf(ma8hths);
            for(int i = 0; i < Mathimata.Count; i++)
            {
                if (IsRegistered[position, i] == true)
                {
                    idx++;
                }
            }
            if (idx < 5)
            {
                return false;
            }
            else { return true; }
        }

        public void RegisterCompletedCorses(Student ma8hths)
        {
            int studpos = Ma8htes.IndexOf(ma8hths);
            for(int i =0; i<Mathimata.Count; i++)
            {
                if (Grades[studpos, i] >= 5)
                {
                    CompCourse[studpos, i] = Grades[studpos, i];
                }
            }
        }

        public double MedianGrade(Student ma8hths)
        {
            int studpos= Ma8htes.IndexOf(ma8hths);
            double MedianNumer = 0;
            double MedianDenom = 0;
            for (int i=0; i < Mathimata.Count; i++)
            {
                if (CompCourse[studpos, i] >= 5)
                {
                    MedianNumer += CompCourse[studpos, i] * Convert.ToDouble(Mathimata[i].Ects);
                    MedianDenom +=  Convert.ToDouble(Mathimata[i].Ects);
                }
            }
            return MedianNumer / MedianDenom;
        }

        public Student[] StudentClassification()
        {
            Student[] studentClassificationArray = new Student[Ma8htes.Count];
            double[] medianGradeArray = new double[Ma8htes.Count];
            int[] values = new int[Ma8htes.Count];

            for(int i =0; i < Ma8htes.Count; i++)
            {
                medianGradeArray[i] = MedianGrade(Ma8htes[i]);
                values[i] = i;
            }
            Array.Sort(medianGradeArray, values);

            for (int i = 0; i < Ma8htes.Count; i++)
            {
                studentClassificationArray[i] = (Ma8htes[values[i]]);
                
            }
            Array.Reverse(studentClassificationArray);

            return studentClassificationArray;

        }
        
    }
}
