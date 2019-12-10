/*
  Author:  Alexan Mardigian
  alex.mardigian@gmail.com
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {
	public float despawnHeight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < despawnHeight) {
			LevelGenerator.level = -1;  // Reset the level counter that is displayed to the user.
			SceneManager.LoadScene("GameOver");
		}
	}
}
