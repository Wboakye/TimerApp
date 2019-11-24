using System;
using System.Threading;


namespace ConsoleAppTest
{
    partial class Program
    {
        public class Reminder
        {
            string text;
            TimeSpan interval;
            NumberOfReminders numberOfReminders;

            public Reminder(ReminderInfo reminderInfo, NumberOfReminders numberOfReminders)
            {
                this.text = reminderInfo.Reminder;
                this.interval = new TimeSpan(reminderInfo.Hours, reminderInfo.Minutes, reminderInfo.Seconds);
                this.numberOfReminders = numberOfReminders;
            }
            public void SetReminder()
            {
                Thread.Sleep(interval);
                Console.WriteLine(text);
                numberOfReminders.number--;
            }
        }

    }
}

