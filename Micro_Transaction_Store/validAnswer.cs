using System;

class validAnswer
{
    public static int numberTest()
    {
        int item = 0;
        bool answerTest = true;

        while (answerTest)
        {
            bool successful = int.TryParse(Console.ReadLine(), out item);

            if (successful == false)
            {
                Console.WriteLine("That is not a number, try again.");
            }
            else
            {
                answerTest = false;
            }
        }
        return item;

    }
}