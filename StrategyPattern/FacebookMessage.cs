using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern
{
    public class FacebookMessage : IFacebookMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Facebookmessenger ");
        }
    }
}
