using System;

namespace Design_Patterns_Assignment
{
    public class MessageHandler
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }

        public static void SendFacebookMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }
}