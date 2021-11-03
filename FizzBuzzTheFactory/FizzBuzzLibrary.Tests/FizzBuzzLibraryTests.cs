using NUnit.Framework;
using FizzBuzzLibrary;

namespace FizzBuzzLibrary.Tests
{
    public class FizzBuzzLibraryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void Buzzer_When_Envio_valor_retorna_valor([Values (1,2,4)] int inputParametro)
        {
            //Arrange
            int input = inputParametro;

            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual(input.ToString(), output);
                    

        }

        [Test]
        public void Buzzer_When_Es_Divisible_Only_by_3([Values(3,6,9)] int inputParametro)
        {
            //Arrange
            int input = inputParametro;

            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("Fizz", output);

        }

        [Test]
        public void Buzzer_When_Es_Divisible_Only_by_5([Values(5,10)] int inputParametro)
        {
            //Arrange
            int input = inputParametro;

            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("Buzz", output);

        }

        [Test]
        public void Buzzer_When_Es_Divisible_by_3_5([Values(15)] int inputParametro)
        {
            //Arrange
            int input = inputParametro;

            //Act
            string output = FizzBuzzer.GetValue(input);


            //Assert
            Assert.AreEqual("FizzBuzz", output);

           

        }

            


    }
}
