namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Deleted : TextDecorator, IDeleted
    {
        public Deleted(IText text) : base(text)
        {
            StartTag = "<del>";
            EndTag = "<del>";
        }
    }
}