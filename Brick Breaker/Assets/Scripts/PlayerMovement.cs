using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
  
    void Update()
    {
        // X axis
        if (transform.position.x <= -8f)
        {
            transform.position = new Vector2(-8.09f, transform.position.y);
        }
        else if (transform.position.x >= 8f)
        {
            transform.position = new Vector2(8.09f, transform.position.y);
        }
        //player movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }

    }

}
