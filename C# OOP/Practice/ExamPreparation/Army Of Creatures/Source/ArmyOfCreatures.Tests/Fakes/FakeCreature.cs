using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests.Fakes
{
    public class FakeCreature : Creature
    {

        //private readonly ICollection<Specialty> specialtiesList;

        public FakeCreature(int attack, int defense, int healthPoints, decimal damage) : base(attack, defense, healthPoints, damage)
        {
   
        }

        public IEnumerable<Specialty> FakeSpecialties
        {
            get
            {
                return new List<Specialty>(base.Specialties);
            }
        }

        //public void FakeAddSpecialty(Specialty specialtyToAdd)
        //{
        //    this.specialtiesList.Add(specialtyToAdd);
        //}
    }
}
