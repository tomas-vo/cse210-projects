using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");
        scripture.DisplayScripture();

        
        while (true)
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            
            scripture.HideWords();
            scripture.DisplayScripture();
        }

        Console.WriteLine("Program ended.");
    }
}

public class Reference
{
    public string ReferenceText { get; private set; }

    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }
}

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(string referenceText, string scriptureText)
    {
        
        ScriptureReference = new Reference(referenceText);
        
        
        Words = new List<Word>();
        foreach (string word in scriptureText.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(ScriptureReference.ReferenceText);
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    
    public void HideWords()
    {
        Random random = new Random();
        int index;
        do
        {
            index = random.Next(Words.Count);
        } while (Words[index].IsHidden);  

        Words[index].IsHidden = true;
    }
}
