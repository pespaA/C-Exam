using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Exams;
using ExamSystem.Questions;

namespace ExamSystem
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Exam Exams { get; set; }

        public Subject(int _Id,string _Name,Exam _exam)
        {
            ID = _Id;
            Name = _Name;
            Exams = _exam;
        }
    }
}
