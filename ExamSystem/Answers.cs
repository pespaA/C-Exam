using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answers(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        }
        public override string ToString()
        {
            return AnswerText;
        }
    }
}
