using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    public GameObject player;
    private float x, speed = 0.15f;
    private float offset = 0, max = 4f;
    private bool right = true;
    int way = 1;

    private Vector3 targetPos, startPos;
    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
        startPos = transform.position;
        targetPos = startPos + new Vector3(max, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //positif if above the middle
        offset = transform.position.x - x;

        if (right)
        {
            if (offset >= max)
            {
                right = false;
                way *= -1;
            }
        }
        else if (!right)
        {
            if (offset <= (-1) * max)
            {
                right = true;
                way *= -1;
            }
        }
        transform.position = Vector3.Lerp(transform.position, transform.position + way * targetPos, speed * Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, startPos + way*targetPos, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //player.transform.position = transform.position + new Vector3(0f, player.transform.localScale.y/2, 0f);
        }
    }
}
