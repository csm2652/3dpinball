using UnityEngine;
using System.Collections;

public class RotateSwitch : MonoBehaviour {
    public Animator animator;
    public Rigidbody rb;
	// Use this for initialization
	void Awake () {
       // rb = GetComponent<Rigidbody>();
        //animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("click");
            if (359 < rb.transform.rotation.z || rb.transform.rotation.z < 1)
            {
                animator.SetBool("0_120", true);
                Debug.Log("click");
            }
            Debug.Log("click");
            if (119 < rb.transform.rotation.z || rb.transform.rotation.z < 121)
            {
                Debug.Log("click");
                animator.SetBool("120_240", true);
            }
            Debug.Log("click");
            if (239 < rb.transform.rotation.z || rb.transform.rotation.z < 241)
            {
                animator.SetBool("240_360", true);
            }
            StartCoroutine(WaitCoroutine2());
           
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(WaitCoroutine1());
            if (359 < rb.transform.rotation.z || rb.transform.rotation.z < 1)
            {
                animator.SetBool("360_240", true);
            }
            if (239 < rb.transform.rotation.z || rb.transform.rotation.z < 241)
            {
                animator.SetBool("240_120", true);
            }
            
            if (119 < rb.transform.rotation.z || rb.transform.rotation.z < 121)
            {
                animator.SetBool("120_0", true);
            }
           
        }
    }

    IEnumerator WaitCoroutine1 ()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("360_240", false);
        animator.SetBool("240_120", false);
        animator.SetBool("120_0", false);
    }
   IEnumerator WaitCoroutine2()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("0_120",false);
        animator.SetBool("120_240", false);
        animator.SetBool("240_360", false);
    }
    void FixedUpdate()
    {

    }
}
