using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour {

    public GameObject prec, next, after;
    private float velocity, offset = 0;
    private float lastX;
	// Use this for initialization
	void Start () {
        velocity = 20f;
        lastX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        lastX = transform.position.x;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //transform.Translate(Vector3.up*Time.deltaTime);
            transform.GetComponent<Rigidbody>().velocity = Vector3.up * Time.deltaTime;
            offset = transform.position.x - lastX; //if > 0, moved up
            if (next)
            {
                //next.transform.Translate(next.transform.position + new Vector3(0f, Mathf.Sign(offset), 0f) * velocity * Time.deltaTime);
                next.GetComponent<Rigidbody>().velocity = Vector3.up * Mathf.Sign(offset) * Time.deltaTime * velocity;
            }
            if (after)
            {
                after.GetComponent<Rigidbody>().velocity = Vector3.down * Mathf.Sign(offset) * Time.deltaTime * velocity;
            }
            if (prec)
            {
                prec.GetComponent<Rigidbody>().velocity = Vector3.up * Mathf.Sign(offset) * Time.deltaTime * velocity;
                //prec.transform.Translate(prec.transform.position + new Vector3(0f, Mathf.Sign(offset), 0f) * velocity * Time.deltaTime);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player")) {
            transform.GetComponent<Rigidbody>().velocity = Vector3.up * Time.deltaTime;
            offset = transform.position.x - lastX; //if > 0, moved up
            if (next)
            {
                next.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (after)
            {
                after.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (prec)
            {
                prec.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }

}
