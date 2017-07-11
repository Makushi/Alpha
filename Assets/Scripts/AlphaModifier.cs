using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaModifier : MonoBehaviour {

	public LayerMask collideMask;
	public GameObject from;
	public GameObject to;
	private Transform last;

	void Update () {
		RaycastHit hit;
		Debug.DrawLine (from.transform.position, to.transform.position, Color.green);
		if (Physics.Linecast (from.transform.position, to.transform.position, out hit, collideMask))
		{
			last = hit.transform;
			Color color = hit.transform.GetComponent<Renderer> ().material.color;
			color.a = 0.5f;
			hit.transform.GetComponent<Renderer> ().material.color = color;
		} 
	}
}
