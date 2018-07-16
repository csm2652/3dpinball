using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newShooter : MonoBehaviour {
    public float maxAngle = 20.0f;
    public float flipTime = 1.0f;
    //public Rigidbody ball;
    private Quaternion initialOrientation;
    private Quaternion finalOrientation;
    private float t;
    //private Vector3 speed = new Vector3(3, 0, 0);
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(KeyCode.A))
        {
			Debug.Log ("get a");
            this.transform.Rotate(0.0f, 0.0f,90.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate( 0.0f, 0.0f,-90.0f * Time.deltaTime);
        }*/
        /*  if (Physics.Raycast(transform.position, ball.transform.position, 1f))
          {
              ball.AddForce(way2go, ForceMode.Impulse);
              Debug.Log("give power");
          }*/
    }
    void FixedUpdate()
    {
        /*{
            if (Input.GetKey(KeyCode.A))
            {
                finalOrientation.eulerAngles = new Vector3(initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y - maxAngle, initialOrientation.eulerAngles.z);
                transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
                t += Time.deltaTime;
                if (t > flipTime)
                {
                    t = flipTime;
                }
            }
            else
            {
                transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
                t -= Time.deltaTime;
                if (t < 0)
                {
                    t = 0;
                }
            }
        }
        {
            if (Input.GetKey(KeyCode.D))
            {
                finalOrientation.eulerAngles = new Vector3(initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z);
                transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
                t += Time.deltaTime;
                if (t > flipTime)
                {
                    t = flipTime;
                }
            }
            else
            {
                transform.rotation = Quaternion.Slerp(initialOrientation, finalOrientation, t / flipTime);
                t -= Time.deltaTime;
                if (t < 0)
                {
                    t = 0;
                }
            }
        }*/
    }
}
