﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
   public class Griffin : Creature
    {
        public Griffin() : base(8, 8, 25 , 4.5m)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
