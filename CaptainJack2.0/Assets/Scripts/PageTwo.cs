using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageTwo : MonoBehaviour {

//This is the script I used to switch from the Help page to the second page of the help section. I could of just used the same script I used for switching the other scenes. 
public void Page2(string Page2button)
{
	SceneManager.LoadScene(Page2button);
}

}
