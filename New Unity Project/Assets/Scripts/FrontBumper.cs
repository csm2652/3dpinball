using UnityEngine;
using System.Collections;

public class FrontBumper : MonoBehaviour {
    public float force;
    public float explosiveR;
    private Vector3 mylocation;
    
    void OnCollisionEnter(Collision col)
    {
        col.rigidbody.AddExplosionForce(force, this.transform.position, explosiveR);    
        //col.rigidbody.AddRelativeForce(new Vector3(Random.Range(force - 15, force + 15), 0 ,Random.Range(force - 15, force + 15)), ForceMode.Impulse);
    }
   
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
