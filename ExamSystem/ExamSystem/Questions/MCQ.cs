using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Questions
{
    internal class MCQ : Question
    {
        public string[] Choices { get; set; }
        public int CorrectAnswerID { get; set; }
        public MCQ(string _Header, string _Body, int _Mark, string[] _Choices, int _CorrectAnswerID) : base(_Header, _Body, _Mark)
        {

            Choices = _Choices;
            CorrectAnswerID = _CorrectAnswerID;
        }

        public override string ToString()
        {
            return $"{Header}     Mark:{Mark}\n{Body}\n" +
                $"Choices:\n" +
                $"1- {Choices[0]}\n" +
                $"2- {Choices[1]}\n" +
                $"3- {Choices[2]}\n";
        }
    }
}
