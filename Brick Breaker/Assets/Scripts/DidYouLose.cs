using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DidYouLose : MonoBehaviour
{
    public int lives;

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bottom")
        {
            lives = lives - 1;

        }

        if (lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
