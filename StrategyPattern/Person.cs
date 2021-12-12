using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Person : IPerson
    {
        public IMessage Message { get; set; }

         public void Send(string message)
        {
            Message.SendMessage(message);
        }
    }
}
