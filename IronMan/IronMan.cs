using SuperHeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMan
{
    public class IronMan : ISuperHero
    {
        public string Name { get => "Tony Stark"; }
        public DateTime DateOfBirth { get => new DateTime(1970, 05, 29); }
        public List<string> Powers { get => new List<string>(){"Super Armor","Missiles","Laser Beams","Sarcasm",}; }
    }
}
