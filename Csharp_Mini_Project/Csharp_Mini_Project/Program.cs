namespace Csharp_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Subjects
            Subject Math = new Subject("Mathematics");
            Subject English = new Subject("English");

            // Question Lists
            QuestionList MathFinalQuestions = new QuestionList("Data\\Math_Final.txt");
            QuestionList EnglishPractQuestions = new QuestionList("Data\\English_Practice.txt");

            // Create Answers
            AnswerList MathAnswer1 = new AnswerList()
            {
                new Answer(1, "3"),
                new Answer(2, "4"),
                new Answer(3, "5")
            };

            // Create Questions
            ChooseOneQuestion mathq1 = new ChooseOneQuestion("Choose One Answer", "2 + 2 = ", 2, MathAnswer1, 2);
            TrueFalseQuestion English1 = new TrueFalseQuestion("Select True or False based on the grammatical correctness of the following question"
            , "I go to school yesterday.", 3,2);

            // Add to question Lists
            MathFinalQuestions.Add(mathq1 );
            EnglishPractQuestions.Add(English1);

            // Create Exams
            FinalExam MathFinal = new FinalExam(new TimeOnly(2, 0), MathFinalQuestions, Math);
            PracticeExam EnglishPractice = new PracticeExam(new TimeOnly(1, 0), EnglishPractQuestions, English);

            Console.WriteLine("Select Subject");
            Console.WriteLine("1 - Math");
            Console.WriteLine("2 - English");
            Console.WriteLine("3 - Science");
            
            string? Choice = Console.ReadLine();

            Console.WriteLine("Select Exam Type");
            Console.WriteLine("1 - Practice Exam");
            Console.WriteLine("2 - Final Exam");

            string? ExamType = Console.ReadLine();

            Exam? SelectedExam = null;

            if (Choice == "1")
            {
                if (ExamType == "2")
                {
                    SelectedExam = MathFinal;
                }

            }
            else if (Choice == "2")
            {
                if (ExamType == "1")
                {
                    SelectedExam = EnglishPractice;
                }
            }
            else 
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            // Avoiding NullReferenceExceptions
            if (SelectedExam == null)
            {
                Console.WriteLine("Invalid Exam Type");
                return;
            }

            Console.WriteLine($"\n -- Exam Started -- \n");
            Console.WriteLine(SelectedExam.ShowExam());
        }
    }

    enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }
}
