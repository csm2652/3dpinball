using UnityEngine;
using System.Collections;

public class frontbumper2 : MonoBehaviour {
    public float force = 100.0f;
    void OnTriggerStay(Collider col)
    {
        Debug.Log("a");
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("aa");
            col.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(force - 15, force + 15), Random.Range(force - 15, force + 15), force + 30), ForceMode.Impulse);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
