﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
   public class CyclopsKing : Creature
    {
        public CyclopsKing() : base(17, 13, 70, 18)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
