using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class OnlineAttendance
    {
        public delegate void BannedUserEventHandler(string userName);
        public static event BannedUserEventHandler OnBannedUserDetected;

       
        static readonly string[] bannedUsers = { "Jack", "Steven", "Mathew" };

        public void onlineAttemdanceDemo()
        {
            
            OnBannedUserDetected += HandleBannedUser;

            Console.WriteLine("Welcome to the Online Attendance System!");
            Console.WriteLine("Please enter your name:");

            string userName = Console.ReadLine();

            if (Array.Exists(bannedUsers, user => string.Equals(user, userName, StringComparison.OrdinalIgnoreCase)))
            {
                
                OnBannedUserDetected.Invoke(userName);
            }
            else
            {
                
                Console.WriteLine($"Welcome, {userName}!");
            }
        }

      
         public static void HandleBannedUser(string userName)
        {
            Console.WriteLine($"ALERT: Banned user detected! Name: {userName}");
            TriggerAlarm();
            SendEmailToAdmin(userName);
        }

        
       public static void TriggerAlarm()
        {
            Console.WriteLine("Alarm triggered!");
        }

       
       public  static void SendEmailToAdmin(string userName)
        {
            Console.WriteLine($"Email sent to administration: Banned user '{userName}' attempted to access the system.");
        }
    }
}
   