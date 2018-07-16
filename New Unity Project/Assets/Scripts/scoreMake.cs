using UnityEngine;
using System.Collections;

public class scoreMake : MonoBehaviour {
    public static int score = 0;
    public int PlusScoreWall = 50;
    public int PlusScoreBump = 30;
    public int PlusScoreSpining = 10;
    public Rigidbody rb;
    public RigidbodyConstraints FixPos;
    public float MinRandomX = -3;
    public float MaxRandomX = 3;
    public float MaxRandomY = 0;
    public float MinRandomY = 8;
    public float MaxRandomZ = -3;
    public float MinRandomZ = 3;
    // Use this for initialization
    void Start () {
        Debug.Log("a");
	}
    void FixedUpdate()
    {
       
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("a");
    }
    void OnCollisionEnter(Collision col)
    {
        //GetComponent<Rigidbody>().constraints = FixPos;
        if (col.collider.tag == "EWall")
        {
            Debug.Log("50");
            score = score + PlusScoreWall;

        }
        if (col.collider.tag == "Bump")
        {
            score = score + PlusScoreBump;

        }
        if (col.collider.tag == "Spining")
        {
            score = score + PlusScoreSpining;

        }
        if(col.collider.tag == "SuperBump")
        {
            //rb.useGravity = false;
            /*FixPos = RigidbodyConstraints.None;
            rb.constraints = FixPos;*/
            rb.AddForce(Random.Range(MinRandomX, MaxRandomX), Random.Range(MinRandomY, MaxRandomY), Random.Range(MinRandomZ, MaxRandomZ), ForceMode.VelocityChange);
        }
        if(col.collider.tag == "JustWall")
        {
            /*FixPos = RigidbodyConstraints.FreezePositionY;*/
            //rb.useGravity = true;
            //GetComponent<Rigidbody>().constraints = FixPos;
        }
    }
}
