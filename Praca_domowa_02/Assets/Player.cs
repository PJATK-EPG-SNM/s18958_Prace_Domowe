using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 500;
    public float jump = 400;

    private Rigidbody2D rb;
    private bool isGrounded;

    int playerObject, collideObject;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown("space") && (isGrounded == true))
        {
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
        if (col.gameObject.name.Equals("Player"))
        {
            this.transform.parent = col.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = true;
        if (col.gameObject.name.Equals("Player"))
        {
            this.transform.parent = null;
        }
    }
}