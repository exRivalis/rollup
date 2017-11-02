using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    private float y, speed = 0.5f;
    private float offset = 0, max = 4f;
    private bool rising = true;
    int way = 1;

    //private Vector3 targetPos, startPos;
    // Use this for initialization
    void Start()
    {
        y = transform.position.y;
        //startPos = transform.position;
        //targetPos = startPos + new Vector3(0f, max, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //positif if above the middle
        offset = transform.position.y - y;

        if(rising)
        {           
            if(offset >= max)
                {
                    rising = false;
                    way *= -1;
                }
        }else if(!rising)
        {
            if (offset <= (-1)*max)
            {
                rising = true;
                way *= -1;
            }
        }
        transform.position = Vector3.Lerp(transform.position, transform.position + way * (new Vector3(0f, 4f, 0f)), speed * Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, startPos + way*targetPos, speed * Time.deltaTime);
    }
}
