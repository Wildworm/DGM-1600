using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{

    public GameManager theGameManager;

    public int lives;


    void Start()
    {
        theGameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (lives > 0)
        {
            lives = lives - 1;
        }
        if (lives == 0)
        {
            theGameManager.LoadLevel("Game Over");
        }
    }
}



