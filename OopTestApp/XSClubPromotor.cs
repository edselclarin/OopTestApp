using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTestApp
{
    internal class XSClubPromotor : Promotor, IVlogger, IBodyBuilder
    {
        public void Vlog()
        {
            Console.WriteLine($"{FirstName} {LastName} posted a video about the XS Club.");
        }

        public void Workout()
        {
            Console.WriteLine($"{FirstName} {LastName} bench pressed today.");
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine($"{FirstName} {LastName} shares with Instagram followers.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine($"{FirstName} {LastName} uses Google AdWords.");
        }
    }
}
