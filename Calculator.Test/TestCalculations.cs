using Calculator.BLL;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class TestCalculations
    {
        [Fact]
        public void InvalidCalMethod_ReturnNull()
        {
            //Given
            string calMethod = Guid.NewGuid().ToString();
            Calculations cal = new();
            //When
            var result = cal.Calculate(calMethod, 1f, 1f);
            //Then
            result.Should().BeNull();
        }

        [Fact]
        public void ADD_TwoFloats_ReturnCorrectSum() 
        {
            //Given
            float number1 = 10f;
            float number2 = 30f;
            string calcMethod = "add";
            Calculations cal = new();
            //When
            float? result = cal.Calculate(calcMethod, number1, number2);
            //Then
            result.Should().Be(40f);
        }

        [Fact]
        public void ADD_TwoMazFloats_() 
        {
            //Given
            float number1 = float.MaxValue;
            float number2 = float.MaxValue;
            string calcMethod = "add";
            Calculations cal = new();
            //When
            float? result = cal.Calculate(calcMethod, number1, number2);
            //Then
            result.Should().Be(float.MaxValue + float.MaxValue);
        }

        [Fact]
        public void Divide_divideWithZero() 
        {
            //Given
            float number1 = 10f;
            float number2 = 0f;
            string calcMethod = "divide";
            Calculations cal = new();
            //When
            float? result = cal.Calculate(calcMethod, number1, number2);
            //Then
            result.Should().Be(number1/number2);
        }


        [Fact]
        public void Subtract_TwoFloats_ReturnCorrectSum() 
        {
            //Given
            float number1 = 30f;
            float number2 = 10f;
            string calcMethod = "subtract";
            Calculations cal = new();
            //When
            float? result = cal.Calculate(calcMethod, number1, number2);
            //Then
            result.Should().Be(20f);
        }

        
    }

}
