using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int health;
    public AudioClip clip;
    public Sprite[] sprites;

    private void Awake()
    {

        GetComponent<SpriteRenderer>().sprite = sprites[0];
    }
    private void Update()
    {
        if (health == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
    }
    private void OnCollisionEnter2D(Collision2D collission)
    {
        health = health - 1;


        if (health <= 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(clip,  new Vector3(0, 0, 0));

        }
    }
}

