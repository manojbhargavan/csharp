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

                for (int index = 0; index < _grades.Count; index++)
                {
                    _stats.Min = Math.Min(_stats.Min, _grades[index]);
                    _stats.Max = Math.Max(_stats.Max, _grades[index]);
                    _stats.Average += _grades[index];
                }
                _stats.Average /= _grades.Count;
                _stats.Average = Math.Round(_stats.Average, 2);

                switch (_stats.Average)
                {
                    case var d when d >= 90.0:
                        _stats.LetterGrade = 'A';
                        break;
                    case var avg when avg >= 80.0 && avg < 90.0:
                        _stats.LetterGrade = 'B';
                        break;
                    case var avg when avg >= 70.0 && avg < 80.0:
                        _stats.LetterGrade = 'C';
                        break;
                    case var avg when avg >= 60.0 && avg < 50.0:
                        _stats.LetterGrade = 'D';
                        break;
                    case var avg when avg >= 50.0 && avg < 40.0:
                        _stats.LetterGrade = 'E';
                        break;
                    default:
                        _stats.LetterGrade = 'F';
                        break;
                }

            }
            _recomputeStats = false;
            return _stats;
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A': AddGrade(90.0); break;
                case 'B': AddGrade(80.0); break;
                case 'C': AddGrade(70.0); break;
                case 'D': AddGrade(60.0); break;
                default: AddGrade(0); break;
            }
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