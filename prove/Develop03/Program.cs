/*
I added extra creativity and exceeded requirements by improving the process of picking random words to hide so that the program will pick from
words that have not already been hidden instead of hiding a word that was previously hidden and also I added a new feature that if the user inputs the word "partial", the program will partially 
hide each word that is not already hidden, keeping only the first letter of the word visible
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference object
        string book = "Romans";
        int chapter = 10;
        int startVerse = 8;
        int endVerse = 9;
        Reference reference = new Reference(book, chapter, startVerse, endVerse);

        // Create scripture object
        string text = "But what saith it? The word is nigh thee, even in thy mouth, and in thy heart: that is, the word of faith, which we preach; That if thou shalt confess with thy mouth the Lord Jesus, and shalt believe in thine heart that God hath raised him from the dead, thou shalt be saved.";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";
        while (userInput != "quit")
        {
            // Write scripture to console
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt for user input
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            // Check if all words have been hidden, end program if so
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            userInput = Console.ReadLine();


            // Hide words (partial will hide part of each word, which is showing creativity and exceeding requirements)
            if (userInput == "partial") 
            {
                scripture.HidePartial();
            }
            else 
            {
                // Hide random words
                scripture.HideRandomWords(3);
            }
        }
    }
}