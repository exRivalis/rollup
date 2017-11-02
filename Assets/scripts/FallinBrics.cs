using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallinBrics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
