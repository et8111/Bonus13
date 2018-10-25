using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] characters = new GameCharacter[5] {new Warrior("GRONK", 20, 2, "FIST"), new Warrior("Kevin", 11,11,"Dagger"), new Wizard("Marin",2,19,5,11),new Wizard("Bradley Beal",10,9,0,6),new Wizard("BARRY THE BATTLE WIZARD",18,5,8,1)};
            foreach (var v in characters)
                Console.WriteLine(v.Play());


        }
    }
}
