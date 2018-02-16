using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collission)
    {
        health = health - 1;

        if (health < (health / 2))
        {
            //need to show damamged sprite
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(clip,  new Vector3(0, 0, 0));

        }
    }
}

