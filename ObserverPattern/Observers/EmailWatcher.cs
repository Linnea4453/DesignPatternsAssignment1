using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    public class EmailWatcher : IEmailWatcher
    {

        public void Update(string email)
        {
            Console.WriteLine("This is the email you all been waiting for!I'm here now!");


        }
    }
}
