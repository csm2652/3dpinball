using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	public float force = 100.0f;
	public float forceRadius = 1.0f;
	
	void OnCollisionEnter()
	{
        Debug.Log("asd");
		foreach(Collider col in Physics.OverlapSphere(transform.position, forceRadius))
		{
			if(col.GetComponent<Rigidbody>())
			{
				col.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(force-10,force+10),0, Random.Range(force - 10, force + 10)),ForceMode.Impulse);
			}
		}
	}
}
