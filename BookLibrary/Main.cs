using BookLibrary.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Main
    {
        static void Main()
        {
            var x = new BookService().GetAll();
        }
    }
}
