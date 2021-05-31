using System.Configuration;

namespace Solid_demo
{
    // IoC container 
    // inversion of control container
    public class Armory
    {
        public static IWeapon GetWeapon()
        {
            //  return new Gun();
            var weapon = ConfigurationManager.AppSettings["weapon"];

            switch (weapon)
            {
                case "Sword": return new Sword();
                case "Gun": return new Gun();
                default:
                    return new Bow();
            }
        }
    }
}
