namespace FunWIthQuizzes;

public class Quiz
{
    public readonly List<Question> questions = [];
    public int NumCorrect {get; set;}


    public void Run ()
    {
        foreach(Question question in questions)
        {
            Console.WriteLine(question);
            List<int> correctResponses = [];
            foreach (int choiceNum in question.Choices.Keys)
            {
                if (question.Choices[choiceNum].Correct)
                {
                    correctResponses.Add(choiceNum);
                }
            }

            List<int> userResponses = [];

            int i = 0;
            while( i < correctResponses.Count)
            {
                Console.WriteLine("Please enter a number: ");

                int userResponse = int.Parse(Console.ReadLine());
                if(userResponses.Contains(userResponse))
                {
                    Console.WriteLine("You already got that one!");
                }
                else if (!correctResponses.Contains(userResponse))
                {
                    Console.WriteLine("Sorry, the correct answer was: ");
                    foreach(int resp in correctResponses)
                    {
                        Console.WriteLine(question.Choices[resp].Content);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Correct!");
                    userResponses.Add(userResponse);
                    if (i == correctResponses.Count -1 )
                    {
                        NumCorrect++;
                    }
                    i++;
                }
            }
        }
        Console.WriteLine(
            Environment.NewLine
                + "You answered " 
                + NumCorrect 
                + " out of " 
                + questions.Count 
                + " questions correctly. Thanks for playing!" 
                + Environment.NewLine);
    }

}
