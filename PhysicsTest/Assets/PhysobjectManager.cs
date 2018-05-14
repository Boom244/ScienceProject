using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysobjectManager : MonoBehaviour {
	public Button cubeButton,cylinderButton,SphereButton,CapsuleButton, exitButton;
	public CreateObjects createObjects;

	// Use this for initialization
	void Start () {
		cubeButton = cubeButton.GetComponent <Button> ();
		cylinderButton = cylinderButton.GetComponent <Button> ();
		SphereButton = SphereButton.GetComponent <Button> ();
		CapsuleButton = CapsuleButton.GetComponent <Button> ();
		exitButton = exitButton.GetComponent <Button> ();
		createObjects = createObjects.GetComponent<CreateObjects> ();

		cylinderButton.onClick.AddListener (ChangeCylinder);
		cubeButton.onClick.AddListener (ChangeCube);
		SphereButton.onClick.AddListener (ChangeSphere);
		CapsuleButton.onClick.AddListener (ChangeCapsule);
		exitButton.onClick.AddListener (ClosePanel);

	}

	void ClosePanel()
	{
		gameObject.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	void ChangeCylinder()
	{
		createObjects.PrimToSpawn = PrimitiveType.Cylinder;
		gameObject.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}
	void ChangeSphere()
	{
		createObjects.PrimToSpawn = PrimitiveType.Sphere;
		gameObject.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	void ChangeCapsule()
	{
		createObjects.PrimToSpawn = PrimitiveType.Capsule;
		gameObject.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	void ChangeCube()
	{
		createObjects.PrimToSpawn = PrimitiveType.Cube;
		gameObject.SetActive (false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

}
