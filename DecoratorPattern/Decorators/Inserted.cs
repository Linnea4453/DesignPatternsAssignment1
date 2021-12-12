using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Inserted : TextDecorator, IInserted
    {
        public Inserted(IText text) : base(text)
        {
            StartTag = "<ins>";
            EndTag = "</ins>";
        }
    }
}
