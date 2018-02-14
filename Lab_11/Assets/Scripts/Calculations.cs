using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculations : MonoBehaviour {
	public InputField txtsideA, txtsideB;
	public Text txtHypo, txtArea;

	//Name: CalcHype
	//Purpose: Calculate the Hypotenuse
	//Inputs: SideA and SideB
	//Outputs: Update txtHyp with Hypotenuse
	//Preconditions: SideA and sideB are positive numbers
	//Postconditions: The output has worked
	public void CalcHype() {
		double SideA, sideB, Hypotenuse;
		double.TryParse(txtsideA.text, out SideA);
		double.TryParse(txtsideB.text, out sideB);

		Hypotenuse = Math.Sqrt(Math.Pow(SideA,2) + Math.Pow(sideB,2));
		
		txtHypo.text = Hypotenuse.ToString();

	}
	public void CalcArea() {
		double sideA, sideB, Area;
		double.TryParse(txtsideA.text, out sideA);
		double.TryParse(txtsideB.text, out sideB);

		Area = (sideA * sideB)/2;
		txtArea.text = Area.ToString();
	}
}

