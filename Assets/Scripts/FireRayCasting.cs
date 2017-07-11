using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRayCasting : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.right ,out hit))
			{
				hit.rigidbody.AddForceAtPosition (transform.right * 10F, hit.point, ForceMode.Impulse);
			}	
		}
	}
}
