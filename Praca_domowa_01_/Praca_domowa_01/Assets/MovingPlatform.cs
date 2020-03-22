using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirX;
    float speed = 2f;
    bool moveingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -2f)
        {
            moveingRight = false;
        }
        else if (transform.position.x < -4f)
        {
            moveingRight = true;
        }
        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
