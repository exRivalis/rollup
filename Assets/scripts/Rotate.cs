using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    // Use this for initialization
    float speed = 35f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);
    }
}
