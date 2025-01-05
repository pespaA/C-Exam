using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Questions;

namespace ExamSystem.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _questions) : base(_Time, _questions)
        {
        }

        public override void ShowExam()
        {
            string QusBody;
            int QusMark;
            StringBuilder[] QusChoices = new StringBuilder[3];
            int QusCorrectAnswerID;
            int anserValue;
            int TotalGrade = 0;
            int Grade = 0;
            Stopwatch stopwatch = new Stopwatch();

            MCQ[] mCQs = new MCQ[questions];
            Answers[] mCQsanswers = new Answers[questions];


            for (int i = 1; i <= questions; i++)
            {
                    Console.WriteLine("MCQ Question");
                    Console.WriteLine("Please Enter Question Body");
                    QusBody = Console.ReadLine();
                    Console.WriteLine("Please Enter Question Mark");
                    QusMark = Program.GetInt();
                    TotalGrade += QusMark;
                    Console.WriteLine("Please Enter Question Choice 1");
                    QusChoices[0] = new StringBuilder(Console.ReadLine());
                    Console.WriteLine("Please Enter Question Choice 2");
                    QusChoices[1] = new StringBuilder(Console.ReadLine());
                    Console.WriteLine("Please Enter Question Choice 3");
                    QusChoices[2] = new StringBuilder(Console.ReadLine());

                    Console.WriteLine("Please Enter Correct Answer ID");
                    QusCorrectAnswerID = Program.GetInt(3, 1);
                    var QusChoicesArr = QusChoices.Select(x => x.ToString()).ToArray();
                    mCQs[i - 1] = new MCQ("MCQ Question", QusBody, QusMark, QusChoicesArr, QusCorrectAnswerID);
            }
            Console.Clear();
            //start Exam
            Console.WriteLine("do you Want To Start The Exam( 1 for Yes ,2 for No )");
            int startExam = Program.GetInt(2, 1);
            if (startExam == 1)
            {
                stopwatch.Start();
                for (int i = 1; i <= questions; i++)
                {
                    if (mCQs[i - 1] is not null)
                    {
                        Console.WriteLine(mCQs[i - 1]);
                        Console.WriteLine("Pease Enter your The Answer Id");
                        anserValue = Program.GetInt(3, 1);
                        mCQsanswers[i - 1] = new Answers(i - 1, anserValue.ToString());
                    }
                }
                stopwatch.Stop();
                double elapsedMinutes = stopwatch.Elapsed.TotalMinutes;
                Console.Clear();

                //report after The Answers
                for (int i = 1; i <= questions; i++)
                {
                    if (mCQs[i - 1] is not null)
                    {
                        Console.WriteLine(mCQs[i - 1]);
                        Console.WriteLine($"Your Answer => {mCQsanswers[i - 1]}");
                        Console.WriteLine($"Right Answer => {mCQs[i - 1].CorrectAnswerID}");
                        if (int.Parse(mCQsanswers[i - 1].AnswerText) == mCQs[i - 1].CorrectAnswerID)
                            Grade = Grade + mCQs[i - 1].Mark;
                    }
                }

                Console.WriteLine($"Your Grade is {Grade} From {TotalGrade}");
                Console.WriteLine($"Your Exam completed in {elapsedMinutes:F2} minutes.");
                Console.WriteLine("Thank You");
            }
        }
    }
}
