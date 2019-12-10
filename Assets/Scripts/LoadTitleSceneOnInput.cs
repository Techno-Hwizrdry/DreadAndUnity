/*
  Author:  Alexan Mardigian
  alex.mardigian@gmail.com
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitleSceneOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		/* Destroy the WhisperSource here, on the GameOver scene,
		   before the WhisperSource has a chance to overlap with the Title scene music.
		*/ 
		Destroy(GameObject.Find("WhisperSource"));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			SceneManager.LoadScene("Title");
		}
	}
}
