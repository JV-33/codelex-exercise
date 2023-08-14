using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_12
{
    public class Student : IStudent
    {
        private List<string> _testsTaken;

        public string[] TestsTaken => _testsTaken.ToArray();

        public Student()
        {
            _testsTaken = new List<string> { "No tests taken" };
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            _testsTaken.Remove("No tests taken");

            double totalQuestions = paper.MarkScheme.Length;
            double correctAnswers = paper.MarkScheme.Where((answer, index) => answers[index] == answer).Count();
            double scorePercentage = (correctAnswers / totalQuestions) * 100;

            string result = $"{paper.Subject}: ";

            if (scorePercentage >= Convert.ToDouble(paper.PassMark.TrimEnd('%')))
            {
                result += $"Passed! ({scorePercentage}%)";
            }
            else
            {
                result += $"Failed! ({scorePercentage}%)";
            }

            _testsTaken.Add(result);
        }
    }
}
