using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {
        private readonly ToyRegister _register;
        private readonly ChildRegister _book;

        public ToyRegisterShould()
        {
            _register = new ToyRegister();
            _book = new ChildRegister();
        }

        [Fact]
        public void AddToy()
        {
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);
            Assert.True(toy != null);
        }

        [Fact]
        public void PopulateListOfToysForChild()
        {
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);
            Assert.True(toysForTerell.Count>0);
        }

        [Fact]
        public void RevokeToyFromChild()
        {
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);
            _register.RevokeToy(toy);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);

            Assert.DoesNotContain(toy, toysForTerell);

        }
        [Fact]
        public void RevokeToyFromOneChildNotTheOtherWithSameToyName()
        {
            Child kid = _book.AddChild("Sam");
            Child kid2 = _book.AddChild("Julia");
            Toy toy = _register.Add("baseball", kid);
            Toy toy2 = _register.Add("baseball", kid2);
            _register.RevokeToy(toy);
            List<Toy>toysForSam = _register.GetToysForChild(kid);
            List<Toy>toysForJulia = _register.GetToysForChild(kid2);
            Assert.DoesNotContain(toy, toysForSam);
            Assert.Contains(toy2, toysForJulia);
        }
    }
}
