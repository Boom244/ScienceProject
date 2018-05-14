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
	public CharacterController cc = GetComponent (typeof(CharacterController)) as CharacterController;

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
			cc.enabled = false;
			cc.GetComponent<FirstPersonController> ().enabled = false;
			spawnui.gameObject.SetActive(true);
		}
	}
	public void SpawnObj() 
	{
		RaycastHit hit;
		if (Physics.Raycast (createCam.transform.position, createCam.transform.forward, out hit, RangeInt) && PrimToSpawn != null) 
		{
			 GameObject gams = GameObject.CreatePrimitive(PrimToSpawn);
			gams.transform.position = hit.point;
			gams.AddComponent<Rigidbody>();	
		}


	}
}
