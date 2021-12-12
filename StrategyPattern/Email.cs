﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Email : IEmail
    {
         public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email ");
        }
    }
}
