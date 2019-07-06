using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;
        private string _name;
        private bool _recomputeStats = true;
        private Statistics _stats;

        public Book(string name)
        {
            _grades = new List<double>();
            _name = name;
            _stats = new Statistics() { Min = double.MaxValue, Max = double.MinValue, Average = 0 };
        }

        public Statistics GetStatistics()
        {
            if (_recomputeStats)
            {
                foreach (var grade in _grades)
                {
                    _stats.Min = Math.Min(_stats.Min, grade);
                    _stats.Max = Math.Max(_stats.Max, grade);
                    _stats.Average += grade;
                }
                _stats.Average /= _grades.Count;
            }
            _recomputeStats = false;
            return _stats;
        }

        public void AddGrade(double grade)
        {
            _grades.Add(grade);
            _recomputeStats = true;
        }

    }
}