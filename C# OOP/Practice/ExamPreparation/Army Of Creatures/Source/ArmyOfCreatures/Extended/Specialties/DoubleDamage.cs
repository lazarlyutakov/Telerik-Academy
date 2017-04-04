using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;
using System.Globalization;

namespace ArmyOfCreatures.Extended.Specialties
{
   public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if(rounds <= 0 || rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 and less or equal to 10");
            }
            this.rounds = rounds;
        }



        public override decimal ChangeDamageWhenAttacking(
                                                            ICreaturesInBattle attackerWithSpecialty,
                                                            ICreaturesInBattle defender,
                                                            decimal currentDamage
                                                          )
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if(this.rounds <= 0)
            {
                return currentDamage;
            }

            rounds--;
            return currentDamage * 2M;
            
            
       
        }

        public override string ToString()
        {
            return string.Format(
                 CultureInfo.InvariantCulture,
                 "{0}({1})",
                 base.ToString(),
                 this.rounds);
        }



    }
}
