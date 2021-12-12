using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    public class SimulatedDatabase2 : IDataRepository
    {
        public string Load(string v)
        {
            return $"{v} from another place";
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving another data \"{data}\" from another place");
        }

    }
}
