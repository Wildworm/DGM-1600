using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour {

    public float ballLaunchSpeed;
    private bool ballInPlay = false;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && ballInPlay == false)
        {
            ballInPlay = true;
            transform.parent = null;
            rb.AddForce(transform.up * ballLaunchSpeed);

        }
    }
}
