﻿using UnityEngine;
using System.Collections;

public class GUIStats : MonoBehaviour {
	
	//GUIStyle civilians;
	//GUIStyle zombies;
	//GUIStyle soldiers;
	//GUIStyle elapsedTime;
	
	void Start() {
		//civilians = new GUIStyle();
		//zombies = new GUIStyle();
		//soldiers = new GUIStyle();
		//elapsedTime = new GUIStyle();
	}
	
	void OnGUI () {
		if (Time.timeScale != 0) {
			if (GUI.Button(new Rect(10, 10, 55, 20), "Restart")) {
				Application.LoadLevel(1);	
			}
		}
		//GUI.Label(new Rect(0, 36, 100, 20), "Elapsed Time: ", elapsedTime);
		//GUI.Label(new Rect(0, 0,  100, 20), "Civilians: ", civilians);
		//GUI.Label(new Rect(0, 12, 100, 20), "Zombies: ", soldiers);
		//GUI.Label(new Rect(0, 24, 100, 20), "Soldiers: ", zombies);
		
	}
}