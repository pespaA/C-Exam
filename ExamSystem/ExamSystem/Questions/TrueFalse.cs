using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Questions
{
    internal class TrueFalse : Question
    {
        public bool CorrectAnswer { get; set; }
        public TrueFalse(string _Header, string _Body, int _Mark, bool _CorrectAnswer) : base(_Header, _Body, _Mark)
        {
            CorrectAnswer = _CorrectAnswer;
        }
        public override string ToString()
        {
            return $"{Header}     Mark:{Mark}\n{Body}";
        }
    }
}
