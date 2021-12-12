using System;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    public class Repository
    {
        public static void Run()
        {
            DataRepository dataRepository = new();

            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            var data = dataRepository.Load("Dataset A");
            var customer = dataRepository.Load("From Table Customer Where Name==Steve"); // this is a search
            var animal = dataRepository.Load("From Table Animal Where Owner==Steve"); // this is a search
            dataRepository.Save(data);
            dataRepository.Save(customer);
            dataRepository.Save(animal);

            Console.WriteLine();
        }
    }
}