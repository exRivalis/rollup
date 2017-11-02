using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampo : MonoBehaviour {

    private float force = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        other.rigidbody.velocity = transform.TransformDirection(new Vector3(0, force, 0));
    }
}
