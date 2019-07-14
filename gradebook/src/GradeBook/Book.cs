using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> _grades;
        public string Name;
        private bool _recomputeStats = true;
        private Statistics _stats;

        public Book(string name)
        {
            _grades = new List<double>();
            Name = name;
            _stats = new Statistics() { Min = double.MaxValue, Max = double.MinValue, Average = 0 };
        }

        public Statistics GetStatistics()
        {
            if (_recomputeStats)
            {
                int index = 0;
                do
                {
                    _stats.Min = Math.Min(_stats.Min, _grades[index]);
                    _stats.Max = Math.Max(_stats.Max, _grades[index]);
                    _stats.Average += _grades[index];
                    index++;
                } while (index < _grades.Count);
                _stats.Average /= _grades.Count;
            }
            _recomputeStats = false;
            return _stats;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
                _recomputeStats = true;
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public bool Contains(double number)
        {
            return _grades.Contains(number);
        }
    }
}