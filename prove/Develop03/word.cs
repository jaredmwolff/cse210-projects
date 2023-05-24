using System;
using System.Collections.Generic;

public class Word
{
    private Scripture scripture;
    private List<string> hiddenWords;

    public Word(Scripture scripture)
        {
            this.scripture = scripture;
            hiddenWords = new List<string>();
        }

    public void Play()
        {
            while (hiddenWords.Count < GetTotalWords())
            {
                Console.Clear();
                DisplayScripture();
                Console.WriteLine();
                Console.WriteLine("Press enter to hide a word or type 'quit' to end the game.");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    break;
                }
                HideWord();
            }
        }

        private void DisplayScripture()
        {
            foreach (Reference reference in scripture.References)
            {
                Console.WriteLine(reference.Verse);
                string[] words = reference.Text.Split(' ');

                foreach (string word in words)
                {
                    if (hiddenWords.Contains(word))
                    {
                        Console.Write("[ ____ ] ");
                    }
                    else
                    {
                        Console.Write(word + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private int GetTotalWords()
        {
            int totalWords = 0;

            foreach (Reference reference in scripture.References)
            {
                totalWords += reference.Text.Split(' ').Length;
            }
            return totalWords;
        }

        private void HideWord()
        {
            int wordIndex = new Random().Next(0, GetTotalWords());
            int currentIndex = 0;

            foreach (Reference reference in scripture.References)
            {
                string[] words = reference.Text.Split(' ');
                if (currentIndex + words.Length > wordIndex)
                {
                    hiddenWords.Add(words[wordIndex - currentIndex]);
                    break;
                }
                currentIndex += words.Length;
            }
        }
}