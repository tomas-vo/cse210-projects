using System;
using System.Collections.Generic;
using System.IO;

public class JournalApp
{
    private List<JournalEntry> journalEntries;
    private string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public JournalApp()
    {
        journalEntries = new List<JournalEntry>();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to Journal App!");
        Console.WriteLine("This app allows you to keep track of your thoughts and experiences by answering simple daily prompts.");
        Console.WriteLine("");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Load journal from a file");
        Console.WriteLine("4. Save journal to a file");
        Console.WriteLine("5. Quit");
    }

    public void WriteEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine("\nToday's prompt: " + prompt);
        Console.Write("Your answer: ");
        string answer = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        JournalEntry entry = new JournalEntry(prompt, answer, date);

        journalEntries.Add(entry);

        Console.WriteLine("Entry saved successfully!\n");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\n--- Your Journal Entries ---");
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in journalEntries)
            {
                Console.WriteLine($"\nDate: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Answer: {entry.Answer}");
                Console.WriteLine("----------------------------");
            }
        }
    }

    public void LoadJournal()
    {
        Console.Write("\nEnter the filename to load from: ");
        string filename = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(filename);
            journalEntries.Clear();

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string answer = parts[2];

                    JournalEntry entry = new JournalEntry(prompt, answer, date);
                    journalEntries.Add(entry);
                }
            }

            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}\n");
        }
    }

    public void SaveJournal()
    {
        Console.Write("\nEnter the filename to save to: ");
        string filename = Console.ReadLine();

        try
        {
            List<string> lines = new List<string>();

            foreach (var entry in journalEntries)
            {
                string line = $"{entry.Date}|{entry.Prompt}|{entry.Answer}";
                lines.Add(line);
            }

            File.WriteAllLines(filename, lines);

            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}\n");
        }
    }
}
