namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Bold : TextDecorator, IBold
    {
        public Bold(IText text) : base(text)
        {
            StartTag = "<b>";
            EndTag = "</b>";
        }
    }
}