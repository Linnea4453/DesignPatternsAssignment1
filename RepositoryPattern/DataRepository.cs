using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    public class DataRepository : IDataRepository
    {
        public SimulatedDatabase2 SimulatedDatabase { get; set; }
     
        public DataRepository()
        {
            SimulatedDatabase = new SimulatedDatabase2();
        }

        public string Load(string v)
        {
            return SimulatedDatabase.Load(v);
        }

        public void Save(string data)
        {
            SimulatedDatabase.Save(data);
            
        }        
    }
}
