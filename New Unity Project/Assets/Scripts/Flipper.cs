using UnityEngine;
using System.Collections;


public class Flipper : MonoBehaviour
{
    public float maxAngle = 20.0f;
    public float flipTime = 1.0f;
    public string buttonName = "Fire1";
    //public Rigidbody ball;
    private Quaternion initialOrientation;
    private Quaternion finalOrientation;
    private float t;
    //private Vector3 speed = new Vector3(3, 0, 0);
    // Use this for initialization
    void Start()
    { 
        initialOrientation = transform.rotation;
        finalOrientation.eulerAngles = new Vector3(initialOrientation.eulerAngles.x, initialOrientation.eulerAngles.y + maxAngle, initialOrientation.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
       
        /*  if (Physics.Raycast(transform.position, ball.transform.position, 1f))
          {
              ball.AddForce(way2go, ForceMode.Impulse);
              Debug.Log("give power");
          }*/
    }
    void FixedUpdate()
    {
        if (Input.GetButton(buttonName))
        {
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
}
