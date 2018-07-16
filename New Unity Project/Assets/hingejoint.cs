using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hingejoint : MonoBehaviour {
    public GameObject leftFlipper;
    public GameObject rightFlipper;
    private Rigidbody leftFlipperRigid;
    private Rigidbody rightFlipperRigid;
    public float torqueForce=10;
    public string button1 = "Fire1";
    public string button2 = "Fire2";
    // Use this for initialization
    void Start () {
        leftFlipperRigid = leftFlipper.GetComponent<Rigidbody>();
        rightFlipperRigid = rightFlipper.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButton(button1))
        {
            AddTorque(rightFlipperRigid, -torqueForce);
            Debug.Log("add");
        }
        if (Input.GetButton(button2))
        {
            AddTorque(leftFlipperRigid, -torqueForce);
            Debug.Log("add");
        }
    }
    void AddTorque(Rigidbody rigid, float force)
    {
        rigid.AddRelativeTorque(Vector3.forward*force);
    }
    void FixedUpdate()
    {

    }
}
