using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    public class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string StartTag;
        public string EndTag;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetInput()
        {
            return StartTag + Text.GetInput() + EndTag;
        }

        public void SetInput()
        {
            throw new NotImplementedException();
        }
    }
}
