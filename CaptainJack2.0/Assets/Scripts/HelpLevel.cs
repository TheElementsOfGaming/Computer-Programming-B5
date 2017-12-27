using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpLevel : MonoBehaviour 
{


//This is the script I use to switch between scenes
public void Help(string HelpButton)
{
	SceneManager.LoadScene(HelpButton);
}
}
