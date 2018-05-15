using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartPlayerCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;	
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
