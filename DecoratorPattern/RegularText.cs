using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    public class RegularText : IRegularText
    {
        public string TextInput { get; set; }

        public RegularText()
        {
            TextInput = "";
        }

        public string GetInput()
        {
            return TextInput;
        }

        public void SetInput()
        {
            bool validInput = false;
            while (!validInput)
            {
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    TextInput = userInput;
                }
            }
        }

      
    }
}
