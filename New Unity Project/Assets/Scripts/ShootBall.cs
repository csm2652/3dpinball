using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootBall : MonoBehaviour
{
	
	public float force = 100.0f;
	public string buttonName = "Fire3";
	
	private List<Rigidbody> ballList = new List<Rigidbody>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown(buttonName))
		{
			foreach(Rigidbody ball in ballList)
			{
				Debug.Log ("Applying Force");
				ball.AddForce(Vector3.forward*force,ForceMode.Impulse);
			}
		}
		if(Input.GetKey(KeyCode.Q))
		{
			Debug.Log ("get a");
			this.transform.Rotate(0.0f, 0.0f,90.0f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.E))
		{
			this.transform.Rotate( 0.0f, 0.0f,-90.0f * Time.deltaTime);
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Object Entered");
		if(col.GetComponent<Rigidbody>())
		{
			Debug.Log("Object Has Rigidbody");
			ballList.Add(col.GetComponent<Rigidbody>());
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		Debug.Log("Object Exited");
		if(col.GetComponent<Rigidbody>())
		{
			Debug.Log("Object Has Rigidbody");
			ballList.Remove(col.GetComponent<Rigidbody>());
		}
	}
}