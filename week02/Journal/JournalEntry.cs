using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Answer { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string answer, string date)
    {
        Prompt = prompt;
        Answer = answer;
        Date = date;
    }
}
