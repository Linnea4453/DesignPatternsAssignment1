using Design_Patterns_Assignment.ObserverPattern;
using System;

namespace Design_Patterns_Assignment
{
    public class Observer
    {
        public static void Run() 
        {
            EmailWatcher EmailWatcher = new();
            Subject subject = new();

          

            subject.RegisterObserver(EmailWatcher);

            Console.WriteLine("Select what you eant to doo!");
            Console.ReadLine();
            Console.WriteLine("Sorry, it dosen't work! This is hos it's gonna be");
            Console.WriteLine("Now we'll register you as a observer");
            Console.ReadKey();
            subject.RegisterObserver(EmailWatcher);
            Console.WriteLine("Done, Welcome!");
            Console.WriteLine("Press a key so we can send you the message");
            Console.ReadKey();
            subject.NotifyObservers();  
            Console.WriteLine("Sweet, we will now unregister you");
            subject.UnRegisterObserver(EmailWatcher);
            Console.WriteLine("See yaa!!");
            Console.ReadKey();
        }
    }
}