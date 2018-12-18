namespace TheTankGame.Tests
{
    using NUnit.Framework;
    using System;
    using System.Text;

    //using TheTankGame.Entities.Miscellaneous;
    //using TheTankGame.Entities.Parts;
    //using TheTankGame.Entities.Vehicles;

    [TestFixture]
    public class BaseVehicleTests
    {
        [Test]
        public void CorrectInitializeRevengerVehicle()
        {
          //  string model, double weight, decimal price, int attack, int defense, int hitPoints, IAssembler assembler

            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            var revenger = new Revenger(model, weight, price, attack, defense, hitpoint, assembler);

            Assert.AreEqual(model, revenger.Model);
            Assert.AreEqual(weight, revenger.Weight);
            Assert.AreEqual(price, revenger.Price);
            Assert.AreEqual(attack, revenger.Attack);
            Assert.AreEqual(defense, revenger.Defense);
            Assert.AreEqual(hitpoint, revenger.HitPoints);
        }

        [Test]
        public void CorrectInitializeVanguardVehicle()
        {
            //  string model, double weight, decimal price, int attack, int defense, int hitPoints, IAssembler assembler

            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            var vanguard = new Vanguard(model, weight, price, attack, defense, hitpoint, assembler);

            Assert.AreEqual(model, vanguard.Model);
            Assert.AreEqual(weight, vanguard.Weight);
            Assert.AreEqual(price, vanguard.Price);
            Assert.AreEqual(attack, vanguard.Attack);
            Assert.AreEqual(defense, vanguard.Defense);
            Assert.AreEqual(hitpoint, vanguard.HitPoints);
        }

        [Test]
        public void DoesModelThrowExceptionIfValueIsNull()
        {
            //  string model, double weight, decimal price, int attack, int defense, int hitPoints, IAssembler assembler

            string model = null;
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () => 
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesWeightThrowExceptionIfValueIsZero()
        {
            string model = "aaa";
            double weight = 0;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () =>
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesPriceThrowExceptionIfValueIsNegativeNumber()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = -1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () =>
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesAttackThrowExceptionIfValueIsNegativeNumber()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = -1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () =>
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesDefenseThrowExceptionIfValueIsNegativeNumber()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = -1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () =>
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesHitPointThrowExceptionIfValueIsNegativeNumber()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = -1;
            var assembler = new VehicleAssembler();
            Assert.Throws(typeof(ArgumentException), () =>
            new Revenger(model, weight, price, attack, defense, hitpoint, assembler));
        }

        [Test]
        public void DoesStringBuilderWorksCorrect()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            
            var revenger = new Revenger(model, weight, price, attack, defense, hitpoint, assembler);

            StringBuilder result = new StringBuilder();

            result.AppendLine($"Revenger - aaa");
            result.AppendLine($"Total Weight: 1.000");
            result.AppendLine($"Total Price: 1.000");
            result.AppendLine($"Attack: 1");
            result.AppendLine($"Defense: 1");
            result.AppendLine($"HitPoints: 1");

            result.Append("Parts: ");

            StringBuilder partsString = new StringBuilder();

            if (partsString.Length > 0)
            {
                string textToAppend = partsString.ToString()
                    .Substring(0, partsString.Length - 2);

                result.Append(textToAppend);
            }
            else
            {
                result.Append("None");
            }

            Assert.AreEqual(result.ToString(), revenger.ToString());
        }

        [Test]
        public void DoesTotalAttackSumIsCorrest()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            var revenger = new Revenger(model, weight, price, attack, defense, hitpoint, assembler);

            var arsenal = new ArsenalPart("aaa", 1, 1, 100);
            revenger.AddArsenalPart(arsenal);
            Assert.AreEqual(101, revenger.TotalAttack);
        }

        [Test]
        public void DoesTotalDefenseSumIsCorrest()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            var revenger = new Revenger(model, weight, price, attack, defense, hitpoint, assembler);

            var shellpart = new ShellPart("aaa", 1, 1,100);
            revenger.AddShellPart(shellpart);
            Assert.AreEqual(101, revenger.TotalDefense);
        }

        [Test]
        public void DoesTotalHitPointSumIsCorrest()
        {
            string model = "aaa";
            double weight = 1;
            decimal price = 1;
            int attack = 1;
            int defense = 1;
            int hitpoint = 1;
            var assembler = new VehicleAssembler();
            var revenger = new Revenger(model, weight, price, attack, defense, hitpoint, assembler);

            var endurance = new EndurancePart("aaa", 1, 1, 100);
            revenger.AddEndurancePart(endurance);
            Assert.AreEqual(101, revenger.TotalHitPoints);
        }
    }
}