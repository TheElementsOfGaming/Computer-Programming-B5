using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSplit2 : MonoBehaviour {
	public Button btnSTG;
    public Button btnHelp;
    public InputField txtNOP;
    public InputField txtNOGP;
    public Text txtJS;
    public Text txtMS;
    public Text txtCMS;
    public Text txtPBF;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		}public void GoldSplitCal(){
		//Declare Constants
	const double JACKS_PCT = .12;
	const double MATES_PCT = .08;
	const int ADMINS = 2;
	const int THREE_COINS = 3;
		//Declare Variables
		int numGold, numPirates, PBF=0, PirateShare=0, crewShare=0, JackShare=0;
		int Matesshare;
		//Parse the input from the input fields for gold and pirates
		int.TryParse(txtNOGP.text, out numGold);
		print("This is the gold:" + numGold);
		int.TryParse(txtNOP.text, out numPirates);
		print("This is the number of Pirates" + numPirates);
		//Add three gold coins to to the crew share
		crewShare = crewShare + THREE_COINS;
		//Minus (Three gold coins times (numPirates minus Admins))
		//From numGold
		numGold = numGold - (THREE_COINS*(numPirates-ADMINS));
		print("This is the gold amount after the crew go to town:" + numGold);
		//Add 12% of the numGold to JackShare
		JackShare = (int)((double)numGold*JACKS_PCT);
		print("This is the Jack's first share:" + JackShare);
		//Minus JackShare from numGold
		numGold -= JackShare;
		//Add 8% of the numGold to MateShare
		Matesshare = (int)((double)numGold*MATES_PCT);
		print("This is the First Mate's first share:" + Matesshare);
		//Minus Matesshare from numgold
		numGold -= Matesshare;
		//Divide numGold by the numPirates and add that number to 
		//JacksShare, Matesshare, crewShare
		JackShare += numGold/numPirates;
		Matesshare += numGold/numPirates;
		crewShare += numGold/numPirates;
		//add the remainder to the PBF
		PBF = numGold % numPirates;
		//Output variables
		txtCMS.text = crewShare.ToString();
		txtJS.text = JackShare.ToString();
		txtMS.text = Matesshare.ToString();
		txtPBF.text = PBF.ToString();

}

}
