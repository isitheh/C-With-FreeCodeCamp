using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationalC_Microsoft
{
    internal class StudentGrade
    {
        decimal currentAssignments = 5m;
        int[] SophiaMarks =
        {
            93, 87, 98, 95, 100
        };
        int[] NicolasMarks =
        {
            80, 83, 82, 88, 85
        };
        int[] ZahirahMarks =
        {
            84, 96, 73, 85, 79
        };
        int[] JeongMarks =
        {
            90, 92, 98, 100, 97
        };

        int SophiaTotal = 0;
        int NicolasTotal = 0;
        int ZahirahTotal = 0;
        int JeongTotal = 0;

        public void CalculateTotals()
        {
            Console.WriteLine("============== Student Grade Totals ==============");
            foreach (int SophiaMark in SophiaMarks)
            {
                SophiaTotal += SophiaMark;
            }
            Console.WriteLine($"Sophia Total Marks: {SophiaTotal}");

            foreach (int NicolasMark in NicolasMarks)
            {
                NicolasTotal += NicolasMark;
            }
            Console.WriteLine($"Nicolas Total Marks: {NicolasTotal}");

            foreach (int ZahirahMark in ZahirahMarks)
            {
                ZahirahTotal += ZahirahMark;
            }
            Console.WriteLine($"Zahirah Total Marks: {ZahirahTotal}");

            foreach (int JeongMark in JeongMarks)
            {
                JeongTotal += JeongMark;
            }
            Console.WriteLine($"Jeong Total Marks: {JeongTotal}");
        }

        decimal SophiaAverage = 0;
        decimal NicolasAverage = 0;
        decimal ZahirahAverage = 0;
        decimal JeongAverage = 0;

        public void CalculateAverages()
        {
            Console.WriteLine("============== Student Grade Averages ==============");
            Console.WriteLine($"Name:\t\tAvg Mark\tGrade");
            foreach (int SophiaMark in SophiaMarks)
            {
                SophiaAverage = SophiaTotal / currentAssignments;
            }
            Console.WriteLine($"Sophia:\t\t{SophiaAverage}\t\t{CalculateGradeSymbols(SophiaAverage)}");

            foreach (int NicolasMark in NicolasMarks)
            {
                NicolasAverage = NicolasTotal / currentAssignments;
            }
            Console.WriteLine($"Nicolas:\t{NicolasAverage}\t\t{CalculateGradeSymbols(NicolasAverage)}");

            foreach (int ZahirahMark in ZahirahMarks)
            {
                ZahirahAverage = ZahirahTotal / currentAssignments;
            }
            Console.WriteLine($"Zahirah:\t{ZahirahAverage}\t\t{CalculateGradeSymbols(ZahirahAverage)}");

            foreach (int JeongMark in JeongMarks)
            {
                JeongAverage = JeongTotal / currentAssignments;
            }
            Console.WriteLine($"Jeong:\t\t{JeongAverage}\t\t{CalculateGradeSymbols(JeongAverage)}");
        }

        private string CalculateGradeSymbols(decimal mark)
        {
            if(mark < 50)
            {
                return "F";
            } 
            else if(mark >= 50 && mark < 60)
            {
                return "D";
            }
            else if (mark >= 60 && mark < 70)
            {
                return "C";
            }
            else if (mark >= 70 && mark < 80)
            {
                return "B";
            }
            else if (mark >= 80 && mark < 90)
            {
                return "A";
            }
            else if (mark >= 90 && mark <= 100)
            {
                return "A+";
            }
            return "Invalid Mark";
        }

        public void StudentGPACalculator()
        {
            int A_Grade = 4;
            int B_Grade = 3;

            string studentName = "Sophia Johansen";

            string course1Name = "English 101";
            int course1Credits = 3;
            int course1Grade = A_Grade;
            string course2Name = "Algebra 101";
            int course2Credits = 3;
            int course2Grade = B_Grade;
            string course3Name = "Biology 101";
            int course3Credits = 4;
            int course3Grade = B_Grade;
            string course4Name = "Computer Science I";
            int course4Credits = 4;
            int course4Grade = B_Grade;
            string course5Name = "Psychology 101";
            int course5Credits = 3;
            int course5Grade = A_Grade;
            int courseCreditTotal = course1Credits + course2Credits + course3Credits + course4Credits + course5Credits;
            int courseGradeTotal = (course1Grade * course1Credits) + (course2Grade * course2Credits) + (course3Grade * course3Credits)
                + (course4Grade * course4Credits) + (course5Grade * course5Credits);
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine("Subject\t\t\tGrade\tCredit");
            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credits}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credits}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credits}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credits}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credits}");
            Console.WriteLine($"Course Credit Total: {courseCreditTotal}");
            Console.WriteLine($"Course Grade Total: {courseGradeTotal}");
            decimal gradePointAverage = (decimal) courseGradeTotal/courseCreditTotal;
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;
            Console.WriteLine($"Final Grade Point Average: {leadingDigit}.{firstDigit}{secondDigit}");
        }
    }
}
