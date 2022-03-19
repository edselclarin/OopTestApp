using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTestApp
{
    internal class BlogWriter : Writer
    {
        public override void Write()
        {
            Console.WriteLine($"{FirstName} {LastName} posted a blog on Wordpress.");
        }

        public override void Vlog()
        {
            Console.WriteLine($"{FirstName} {LastName} posted a video on YouTube about how to start your own blog.");
        }
    }
}
