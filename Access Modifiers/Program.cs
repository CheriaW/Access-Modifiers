using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //class //variable     //get info from the inside of (from constructors from "Boat" class)
            Boat ssWetDude = new Boat(3, "SS Wet Dude", 18.6);
            ssWetDude.Move();


            //we can access these feilds because theyre public
            //we dont see engineSize or calculateMPG when typing in the field names (as suggestions)
            //program doesnt see that they even exist. why?

            ssWetDude.BoatInfo();

            Boat ssWetMonkey = new Boat(12, "SS Wet Monkey", 48.2);
            ssWetMonkey.BoatInfo();
        }
    }
}
