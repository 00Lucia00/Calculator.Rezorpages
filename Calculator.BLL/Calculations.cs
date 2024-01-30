using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BLL
{
	public class Calculations
	{
		public float? Calculate(string calcMethod, float firstnumber, float secondnumber)
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
					return null;
				}
			}
		}

		//Calculation methods
		//ADD
		private float Add(float firstnumber, float secondnumber) 
		{ 
		    return firstnumber + secondnumber;
		}
		//Subtract
		private float Subtract(float firstnumber, float secondnumber) 
		{ 
		    return firstnumber - secondnumber;
		}
		//Multiply
		private float Multiply(float firstnumber, float secondnumber) 
		{ 
		    return firstnumber * secondnumber;
		}
		//Divide
		private float Divide(float firstnumber, float secondnumber) 
		{ 
		    return firstnumber / secondnumber;
		}
	}
}
