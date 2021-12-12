using Design_Patterns_Assignment;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator


    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorate your text");
            Console.WriteLine("----------------------");
   
          
            Console.WriteLine("Press A to print styled text");
            Console.WriteLine("Press B for Bold");
            Console.WriteLine("Press C for Deleted");
            Console.WriteLine("Press D for Emphasized");
            Console.WriteLine("Press E for Important");
            Console.WriteLine("Press F for Inserted");
            Console.WriteLine("Press G for Italic");
            Console.WriteLine("Press H for Marked");
            Console.WriteLine("Press I for Smaller");
            Console.WriteLine("Press J for SubScript");
            Console.WriteLine("Press K for SuperScript");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Please enter the text.");

            Console.WriteLine();

            var decorate = Factory.CreateText();
            decorate.SetInput();
            var newDecorate = decorate;
        
            while (true)
            {

                Console.WriteLine("Add a tag style or press A for finished: ");
                
                // User input = text yoy want to style
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        ClearRow();
                        Console.WriteLine($"Decorated text: {decorate.GetInput()}");
                        decorate = newDecorate;
                        break;
                    case 'b' or 'B':
                        ClearRow();
                        Console.WriteLine("Adding Bold to text");
                        decorate = new Bold(decorate);
                        break;
                    case 'c' or 'C':
                        ClearRow();
                        Console.WriteLine("Adding Deleted to text");
                        decorate = new Deleted(decorate);
                        break;
                    case 'd' or 'D':
                        ClearRow();
                        Console.WriteLine("Adding Emphasized to text");
                        decorate = new Emphasized(decorate);
                        break;
                    case 'e' or 'E':
                        ClearRow();
                        Console.WriteLine("Adding Important to text");
                        decorate = new Important(decorate);
                        break;
                    case 'f' or 'F':
                        ClearRow();
                        Console.WriteLine("Adding Inserted to text");
                        decorate = new Inserted(decorate);
                        break;
                    case 'g' or 'G':
                        ClearRow();
                        Console.WriteLine("Adding Italic to text");
                        decorate = new Italic(decorate);
                        break;
                    case 'h' or 'H':
                        ClearRow();
                        Console.WriteLine("Adding Marked to text");
                        decorate = new Marked(decorate);
                        break;
                    case 'i' or 'I':
                        ClearRow();
                        Console.WriteLine("Adding Smaller to text");
                        decorate = new Smaller(decorate);
                        break;
                    case 'j' or 'J':
                        ClearRow();
                        Console.WriteLine("Adding Subscript to text");
                        decorate = new Subscript(decorate);
                        break;
                    case 'k' or 'K':
                        ClearRow();
                        Console.WriteLine("Adding Superscript to text");
                        decorate = new Superscript(decorate);
                        break;
                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 20);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}