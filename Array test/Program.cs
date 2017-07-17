using System;

namespace Array_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a phrase I reversed it on purpose to show you what happens
            string phrase = "!hsup elttil a si sekat ti lla ytivarg ekil si wonk uoy sa ssendaM ";

            // creating a array using all the charaters from the phrase and reverse them
            char[] charArray = phrase.ToCharArray();
            Array.Reverse(charArray);

            // grabs all letters in a reverse order and will display to the screen the entire phrase in reverse
            foreach (char phraseChar in charArray)
            {
                Console.Write(phraseChar);
            }
            Console.ReadLine();
        }
    }
}
