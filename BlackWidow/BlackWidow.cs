﻿using SuperHeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackWidow
{
    public class BlackWidow : ISuperHero
    {
        public string Name { get => "Natalia Alianovna Romanova"; }
        public DateTime DateOfBirth { get => new DateTime(1989, 08, 27); }
        public List<string> Powers { get => new List<string>() { "Social Hacking", "Acrobatics", "Acting", "Martial Arts" }; }
    }
}
