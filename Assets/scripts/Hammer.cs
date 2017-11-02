using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    // Use this for initialization
    public GameObject prec;
    private float offset;
    private float startY;

	void Start () {
        if (prec) offset = prec.transform.position.y - transform.position.y;
        else offset = 0;

        startY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (prec)
        {
            if(Mathf.Abs(offset) > 2)
            {
                //prec.get
            }

            offset = prec.transform.position.y - transform.position.y;
        }
        else
        {
            //the first
           if(startY - transform.position.y < 3) transform.Translate(new Vector3(0f, -3f, 0f)*Time.deltaTime);
        }
    }

    public void Up()
    {

    }

    public void Down()
    {

    }
}
