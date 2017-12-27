using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipCalculator : MonoBehaviour {
	//Declare public objects
	public Button btnCalculate;

	public InputField txtMealAmt;

	public Text txtPoorTip; 

	public Text txtAverageTip;

	public Text txtExcellentTip;
	// Use this for initialization
	void Start (){
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void calculateTips(){
		print ("You clicked the button");

		//Declare constants
		const double POOR_TIP = 0.10;
		const double AVG_TIP = 0.15;
		const double EXE_TIP = 0.20;
		//Declare variables 
		double mealAmount, poorTip, avgTip, exeTip;
		//Parse the meal amount from the input field into the 
		//meal amount variable
		double.TryParse(txtMealAmt.text,out mealAmount);
		print(mealAmount);
		//Calculate the poor tip
		poorTip = mealAmount * POOR_TIP; 
		//Calculate the average tip
		avgTip = mealAmount * AVG_TIP;
		//Calculate the excellent tip
		exeTip = mealAmount * EXE_TIP;
		//display results
		txtAverageTip.text = string.Format("{0:C}",avgTip);
		txtExcellentTip.text = string.Format("{0:C}",exeTip);
		txtPoorTip.text = string.Format("{0:C}",poorTip);
	}
}
