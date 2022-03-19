using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTestApp
{
    internal class BookWriter : Writer
    {
        public override void Write()
        {
            Console.WriteLine($"{FirstName} {LastName} published a book with Random House.");
        }

        public override void Vlog()
        {
            Console.WriteLine($"{FirstName} {LastName} posted a video on YouTube about publishing a book.");
        }
    }
}
