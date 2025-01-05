using ExamSystem.Exams;
using ExamSystem.Questions;

namespace ExamSystem
{
    internal class Program
    {
        public static int GetInt(int max = 999,int min = 0)
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int result = int.Parse(input);
                    if (result >= min && result <= max )
                        return int.Parse(input);
                    else
                        Console.WriteLine("Invalid input. Please try again.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
        public static bool GetBool()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try { bool result = bool.Parse(input); return bool.Parse(input); }
                catch { Console.WriteLine("Invalid input. Please try again."); }
            }
        }
        static void Main(string[] args)
        {
            int time;
            int NumberOfQustions;
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("Please Enter The Type Of Exam \n1 for Practical Exam \n2 For Final Exam\n0 to close");
                i = GetInt(2,0);
                if (i == 1)
                {
                    Console.WriteLine("Please Enter Time For Exam 30 min to 180 min");
                    time = GetInt(180,30);
                    Console.WriteLine("Please Enter The Number Of Qustions");
                    NumberOfQustions = GetInt();
                    Exam exam = new PracticalExam(time,NumberOfQustions);
                    exam.ShowExam();
                }
                if (i == 2)
                { 
                    Console.WriteLine("Please Enter Time For Exam 30 min to 180 min");
                    time = GetInt(180, 30);
                    Console.WriteLine("Please Enter The Number Of Qustions");
                    NumberOfQustions = GetInt();
                    Exam exam = new FinalExam(time, NumberOfQustions);
                    exam.ShowExam();
                }
            }
        }
    }
}
