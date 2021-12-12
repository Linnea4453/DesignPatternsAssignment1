using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.StrategyPattern;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategys 
    {    
        public static void Run()
        {
            Person person = new();
            Email email = new();
            SMS sms = new();
            FacebookMessage faceBookMessage = new FacebookMessage();

            Console.WriteLine("  Select an action   ");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Send message by your choice below");
            Console.WriteLine("S: Sms");
            Console.WriteLine("E: Email");
             Console.WriteLine("F: FacebookMessage");
            Console.WriteLine("X: Exit Program");

            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;
                var message = "This is the message you want";

                switch (userInput)
                {
                    case 's' or 'S':
                        ClearRow();
                        person.Message = sms;
                     
                        person.Send(message);
                        MessageHandler.SendSMS(message);


                        break;
                    case 'e' or 'E':
                        ClearRow();
                        person.Message = email;
                        person.Send(message);
                        MessageHandler.SendEmail(message);
                        break;

                    case 'f' or 'F':
                        ClearRow();
                        person.Message = faceBookMessage;
                        person.Send(message);
                        MessageHandler.SendFacebookMessage(message);

                        break;
                    case 'x' or 'X':
                        ClearRow();
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");

        }

        
    }
}