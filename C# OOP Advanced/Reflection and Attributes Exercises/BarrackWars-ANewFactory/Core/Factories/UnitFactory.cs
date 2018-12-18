namespace _03BarracksFactory.Core.Factories
{
    using System;
    using _03BarracksFactory.Models.Units;
    using BarrackWars_ANewFactory.Models.Units;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();

                case "Pikeman":
                    return new Pikeman();

                case "Swordsman":
                    return new Swordsman();

                case "Gunner":
                    return new Gunner();

                case "Horseman":
                    return new Horseman();
                default:
                    return null;
            }
        }
    }
}
