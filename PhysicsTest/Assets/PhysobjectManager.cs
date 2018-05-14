using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysobjectManager : MonoBehaviour {
	public Button cubeButton,cylinderButton,SphereButton,CapsuleButton;
	public CreateObjects createObjects;
	// Use this for initialization
	void Start () {
		cubeButton = cubeButton.GetComponent <Button> ();
		cylinderButton = cylinderButton.GetComponent <Button> ();
		SphereButton = SphereButton.GetComponent <Button> ();
		CapsuleButton = CapsuleButton.GetComponent <Button> ();
		createObjects = createObjects.GetComponent<CreateObjects> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
