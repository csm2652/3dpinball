using UnityEngine;
using System.Collections;

public class ApplyForceAtOffet : MonoBehaviour {

	public float force = 100.0f;
	public Vector3 forceDirection = Vector3.forward;
	public string buttonName = "Fire1";
	public Vector3 offset;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if(Input.GetButton(buttonName))
		{
			GetComponent<Rigidbody>().AddForceAtPosition(forceDirection.normalized*force,transform.position+offset);
		}
		else
		{
			GetComponent<Rigidbody>().AddForceAtPosition(forceDirection.normalized*-force,transform.position+offset);
		}
	}
}
