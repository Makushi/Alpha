using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	float timer = 0.0f;

	void Start () {
		
	}
	
	//<>
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > 2.0f) 
		{
			timer = 0.0f;

			int i = Random.Range (0, prefabs.Length);
			Vector3 prefabPosition = new Vector3 (Random.Range(-5,6), 10, Random.Range(-5,6));
			Instantiate (prefabs [i], prefabPosition, Quaternion.identity);
		}


	}
}