﻿using SuperHeroBase;
using System;
using System.Collections.Generic;

namespace Batman
{
    public class Batman : ISuperHero
    {
        public string Name { get => "Bruce Wayne"; }
        public DateTime DateOfBirth { get => new DateTime(1967, 07, 03); }
        public List<string> Powers { get => new List<string>() { "Money", "Batmobile", "Jujutsu", "Batwing" }; }
    }
}
