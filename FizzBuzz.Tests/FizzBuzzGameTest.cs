using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP___FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzGameTest
    {
        
        [TestMethod] // Si le nombre est 0 ou négatif -> Une erreur est levée.
        public void should_throw_if_is_0_or_negative()
        {
            Assert.ThrowsException<ArgumentException>(() => FizzBuzzGame.play(0));
            Assert.ThrowsException<ArgumentException>(() => FizzBuzzGame.play(-1));
        }
        
        [TestMethod] // Si le nombre est un multiple de 3 -> Fizz.
        public void should_return_Fizz_if_modulo_3()
        {
            Assert.AreEqual("Fizz",FizzBuzzGame.play(3));
            Assert.AreEqual("Fizz",FizzBuzzGame.play(6));
        }
        
        [TestMethod] // Si le nombre est un multiple de 5 -> Buzz.
        public void should_return_Buzz_if_modulo_5()
        {
            Assert.AreEqual("Buzz",FizzBuzzGame.play(5));
            Assert.AreEqual("Buzz",FizzBuzzGame.play(10));
        }
        
        [TestMethod] // Si le nombre est un multiple de 3 et de 5 -> FizzBuzz.
        public void should_return_FizzBuzz_if_modulo_3_and_5()
        {
            Assert.AreEqual("FizzBuzz",FizzBuzzGame.play(15));
            Assert.AreEqual("FizzBuzz",FizzBuzzGame.play(30));
        }
        
        [TestMethod] // Si aucun des cas précédents, répète le nombre de Alice.
        public void should_return_number_if_not_modulo_3_or_5()
        {
            Assert.AreEqual("1",FizzBuzzGame.play(1));
            Assert.AreEqual("2",FizzBuzzGame.play(2));
        }
    }
}