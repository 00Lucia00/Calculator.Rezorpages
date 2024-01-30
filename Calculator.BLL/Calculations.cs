using Calculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BLL
{
	public class Calculations
	{
		public CalculationResult Calculate(string calcMethod, float firstnumber, float secondnumber)
		{
			switch (calcMethod)
			{
				case "add":
				{
					return Add(firstnumber, secondnumber);
				}
				case "subtract":
				{
					return Subtract(firstnumber,secondnumber);
				}
				case "multiply":
				{
					return Multiply(firstnumber,secondnumber);
				}
				case "divide":
				{
					return Divide(firstnumber,secondnumber);
				}
				default:
				{
					return new CalculationResult()
					{ 
					  Successful = false,
					  Error = new ArgumentException("Not a valid calculation method")
					};
				}
			}
		}

		//Calculation methods
		//ADD
		private CalculationResult Add(float firstnumber, float secondnumber) 
		{
			try
			{
				float result = firstnumber + secondnumber;
				CalculationResult calResult = new()
				{
					Successful = true,
					Result = result
				};
				return calResult;
			}
		    catch (Exception e)
			{
				CalculationResult calResult = new()
				{
					Successful = false,
				    Error = e
				};
				return calResult;
			}
		}
		//Subtract
		private CalculationResult Subtract(float firstnumber, float secondnumber) 
		{
            try
            {
                float result = firstnumber - secondnumber;
                CalculationResult calResult = new()
                {
                    Successful = true,
                    Result = result
                };
                return calResult;
            }
            catch (Exception e)
            {
                CalculationResult calResult = new()
                {
                    Successful = false,
                    Error = e
                };
                return calResult;
            }
        }
		//Multiply
		private CalculationResult Multiply(float firstnumber, float secondnumber) 
		{
            try
            {
                float result = firstnumber * secondnumber;
                CalculationResult calResult = new()
                {
                    Successful = true,
                    Result = result
                };
                return calResult;
            }
            catch (Exception e)
            {
                CalculationResult calResult = new()
                {
                    Successful = false,
                    Error = e
                };
                return calResult;
            }
        }
		//Divide
		private CalculationResult Divide(float firstnumber, float secondnumber) 
		{
            try
            {
				if (secondnumber == 0f ) // detta kaster ner värdet till catch
				{
					throw new DivideByZeroException();
				}

                float result = firstnumber / secondnumber;
                CalculationResult calResult = new()
                {
                    Successful = true,
                    Result = result
                };
                return calResult;
            }
            catch (Exception e)
            {
                CalculationResult calResult = new()
                {
                    Successful = false,
                    Error = e
                };
                return calResult;
            }
        }
	}
}
