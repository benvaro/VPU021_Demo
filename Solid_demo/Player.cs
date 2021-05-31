using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_demo
{
    class Player
    {
        private readonly IWeapon _weapon;

        // injection via ctor
        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Fight()
        {
            Console.WriteLine(_weapon.Damage);
        }

        // Square
        // Rectangle
    }
}
