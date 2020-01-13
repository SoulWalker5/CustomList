using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    public interface ICustomList
    {
        void Add(Notebook value);
        Notebook this[int index] { get; }
        void Delete(Notebook value);
    }
}
