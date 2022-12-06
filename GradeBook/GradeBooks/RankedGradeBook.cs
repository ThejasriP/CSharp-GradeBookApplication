using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }


            IEnumerable<Student> orderedStudents = Students.OrderByDescending(student => student.AverageGrade);


            int idx = 0;
            foreach (Student student in orderedStudents)
            {
                if (averageGrade > student.AverageGrade)
                {
                    break;
                }

                idx++;
            }

            double percentile = (double)idx / (double)Students.Count * 100;

            if (percentile <= 20.00)
            {
                return 'A';
            }
            else if (percentile <= 40.00)
            {
                return 'B';
            }
            else if (percentile <= 60.00)
            {
                return 'C';
            }
            else if (percentile <= 80.00)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }
    }
}
