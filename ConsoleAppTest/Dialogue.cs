using System;


namespace ConsoleAppTest
{
    partial class Program
    {
        public class Dialogue
        {
            private string introduction = "What can I remind you about?";
            public bool AskQuestion = true;

            private Reminder reminder;

            public int ReminderItem;

            public Dialogue(int reminderItem)
            {
                ReminderItem = reminderItem;
            }
            public Reminder StartDialogue(NumberOfReminders numberOfReminders)
            {
                ReminderInfo reminderInfo = new ReminderInfo();

                Console.WriteLine(introduction);
                reminderInfo.Reminder = Console.ReadLine();
                Console.WriteLine($"How long should I wait to remind you about it?");
                Console.WriteLine("Hours?");
                reminderInfo.Hours = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Minutes?");
                reminderInfo.Minutes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Seconds?");
                reminderInfo.Seconds = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Excellent! I'll remind you in {reminderInfo.Hours} hours, {reminderInfo.Minutes} minutes, and {reminderInfo.Seconds} seconds!");
                reminder = new Reminder(reminderInfo, numberOfReminders);
                return reminder;
            }

            public bool CheckForMore()
            {
                bool improperResponse = false;
                Console.WriteLine("Is that it? \"Y\" for yes, \"N\" for no.");

                do
                {
                    string response = Console.ReadLine();
                    string keepGoing = response.ToLower();
                    if (keepGoing == "y" || keepGoing == "n")
                    {
                        if (keepGoing == "y")
                        {
                            Console.WriteLine("Standby for reminders.");
                            return false;
                        }
                        else
                        {
                            introduction = "What else can I remind you about?";
                            return true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Improper response.");
                        Console.WriteLine("Is that it? \"Y\" for yes, \"N\" for no.");
                        improperResponse = true;
                    }
                } while (improperResponse);
                return improperResponse;
            }
        }

    }
}

