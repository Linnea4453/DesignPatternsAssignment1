using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    public interface IDataRepository
    {
        void Save(string data);

        string Load(string v);
    }
}
