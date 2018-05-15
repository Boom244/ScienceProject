	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class CreateObjects : MonoBehaviour {
	public Camera createCam; 
	public float RangeInt = 20f;
	public GameObject spawnui;
	public PrimitiveType PrimToSpawn;

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) {
			SpawnObj();
		}

		if (Input.GetButtonDown("Fire2"))
		{
			///Reactivates selection GUI, and then frees the cursor
			spawnui.gameObject.SetActive(true);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}
	public void SpawnObj() 
	{
		RaycastHit hit;
		if (Physics.Raycast (createCam.transform.position, createCam.transform.forward, out hit, RangeInt) && PrimToSpawn != null) 
		{
			
			///Adds object to the scene at boosted position
			 GameObject gams = GameObject.CreatePrimitive(PrimToSpawn);
			gams.transform.position = new Vector3 (hit.point.x, hit.point.y + 1 / 2	, hit.point.z);
			gams.AddComponent<Rigidbody>();	
		}


	}
}
