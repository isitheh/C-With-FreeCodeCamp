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
    }
}
