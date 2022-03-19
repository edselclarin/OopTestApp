using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTestApp
{
    internal class OmniaClubPromotor : Promotor
    {
        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine($"{FirstName} {LastName} shares with friends.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine($"{FirstName} {LastName} uses Facebook Ads.");
        }
    }
}
