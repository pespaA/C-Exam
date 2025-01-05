using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Questions
{
    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Question(string _Header, string _Body, int _Mark)
        {
            Header = _Header;
            Body = _Body;
            Mark = _Mark;
        }

        //public override string ToString()
        //{
        //    return $"Header : {Header}\nBody : {Body}\nMark : {Mark}";
        //}
    }

}
