using Design_Patterns_Assignment.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Timers;

namespace Design_Patterns_Assignment
{
      class Subject : ISubject
    {
        public string Message { get; set; }
        public List<IObserver> Observers { get; set; }
      

        public Subject()
        {
            Observers = new();
         
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }


    }
}