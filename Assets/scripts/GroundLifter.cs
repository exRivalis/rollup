using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLifter : MonoBehaviour {

    public GameObject lowerStep, heigherStep;
    private Vector3 start, lStart, hStart;
    private float speed = 0.05f;
	// Use this for initialization
	void Start () {
        start = transform.localPosition;
        lStart = lowerStep.transform.localPosition;
        hStart = heigherStep.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float offset = start.y - transform.localPosition.y;
        if ( offset > 0.1f && offset < 0.2f)
        {
            lowerStep.transform.Translate(Vector3.Lerp(lStart, lStart + new Vector3(0f, 15, 0f), speed*Time.deltaTime));
            heigherStep.transform.Translate(Vector3.Lerp(lStart, lStart + new Vector3(0f, 30, 0f), speed*Time.deltaTime));
            //Debug.Log(lStart + "   " + hStart);
        }
    }
}
