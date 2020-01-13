using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebookcollection = new CustomList();

            var igor = new Notebook(1, "Igor");
            var vasia = new Notebook(2, "vasia");
            var kurlik = new Notebook(3, "KYPJIbIK");
            notebookcollection.Add(igor);
            notebookcollection.Add(vasia);
            notebookcollection.Add(kurlik);

            //foreach (var notebook in notebookcollection)
            //    Console.WriteLine(notebook);
        }
    }
}
