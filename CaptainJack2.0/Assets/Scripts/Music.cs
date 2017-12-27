using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
//This is called when a script instance is being loaded.
void Awake()
{

	//This portion of the script that the computer to look for a GameObject that has the tag Music. Then if there is more then one object with the music tag delete the object except one. 
	//If there is only one then don't delete said object. 
	GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
	if(objs.Length > 1)
		Destroy(this.gameObject);

		DontDestroyOnLoad(this.gameObject);
		
	}
}