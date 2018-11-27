using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker :IEnumerable
    {
        IEnumerator GetEnumerator();
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}