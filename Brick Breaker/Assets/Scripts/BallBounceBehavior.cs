using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceBehavior : MonoBehaviour
{
    private float playerVelocit;
    private Rigidbody2D rb;
    public float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PRight")
        {
            new Vector2(speed, 0);
        }

        if (collision.gameObject.name == "PLeft")
        {
            rb.AddForce(transform.right * (0 - speed));
        }
    }
}