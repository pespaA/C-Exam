using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Questions;

namespace ExamSystem.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }
        //public Question[] questions { get; set; }
        public int questions { get; set; }

        public Exam(int _Time, int _questions)
        {
            Time = _Time;
            questions = _questions;
        }
        public abstract void ShowExam();
    }
}
