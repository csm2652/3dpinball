using UnityEngine;
using System.Collections;

public class MoveToOtherPlane : MonoBehaviour {

    public float MinRandomX=-3;
    public float MaxRandomX=3;
    public float MaxRandomY=-3;
    public float MinRandomY=3;
    public float exForce = 100;
    public Rigidbody BallRB;
    public GameObject Target;
    public Collider coverplane1;
    public Collider coverplane2;
    public Collider coverplane3;
    private Vector3 Randomdata;
	// Use this for initialization
	void Start () {
        Randomdata = new Vector3(Random.Range(MinRandomX, MaxRandomX), Random.Range(MinRandomY, MaxRandomY), 10);
        Randomdata.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        coverplane1.isTrigger = true;
        coverplane2.isTrigger = true;
        coverplane3.isTrigger = true;
        BallRB.transform.LookAt(Target.transform.position);
        BallRB.velocity = Vector3.zero;
        BallRB.AddForce(((BallRB.transform.forward+Randomdata))*exForce, ForceMode.Impulse);
        Debug.Log("poweron");
        WaitCoroutine();
    }
    IEnumerator WaitCoroutine()
    {
        
        yield return new WaitForSeconds(0.4f);
        coverplane1.isTrigger = false;
        coverplane2.isTrigger = false;
        coverplane3.isTrigger = false;
        //BallRB.AddForce(Random.Range(MinRandomX, MaxRandomX), Random.Range(MinRandomY, MaxRandomY), Random.Range(MinRandomZ, MaxRandomZ), ForceMode.Impulse);
    }
}
