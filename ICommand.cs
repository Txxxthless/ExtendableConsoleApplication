using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal interface ICommand
    {
        public T Execute<T>();
        public void GetDescription();
    }
}
