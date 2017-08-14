using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTVNs7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Decimal to Binary
		int number, i, j,displayNumber, remainder;
		string binaryNum = string.Empty;
		print("Convert a decimal number to binary");	
		number = 10;	 
		displayNumber = number;
		while (number > 0) {
			remainder = number % 2;
			binaryNum = remainder.ToString() + binaryNum ;
			number = number / 2;
		}
		print("The Binary of " + displayNumber +  " is "  + binaryNum);


		//Highest Common Factor
		int number1, number2, hcf=1; 
		print ("Determine the HCF of two numbers: ");
		number1 = 100;	
		print("1st number for HCF: " + number1);  
		number2 = 25;
		print("2nd number for HCF: " + number2);  
			
		j = (number1<number2) ? number1 : number2;  
		for(i=1; i<=j; i++)  
		{  
			if(number1%i==0 && number2%i==0)  
			{  
				hcf = i;  
			}  
		}  
		print("HCF of "+ number1 +" and "+ number2 +" is :" + hcf);  
	}
	

}
