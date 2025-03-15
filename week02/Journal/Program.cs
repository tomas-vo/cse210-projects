using System;

class Program
{
    static void Main(string[] args)
    {
        JournalApp app = new JournalApp();
        bool running = true;

        while (running)
        {
            app.DisplayMenu();
            Console.Write("\nChoose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    app.WriteEntry();
                    break;

                case "2":
                    app.DisplayJournal();
                    break;

                case "3":
                    app.LoadJournal();
                    break;

                case "4":
                    app.SaveJournal();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
