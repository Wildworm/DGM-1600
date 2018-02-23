using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCount : MonoBehaviour {

    public string level;
    public int numberOfBricks;

    private void Start()
    {
        numberOfBricks = transform.childCount;

    }

    void Update () 
        {
        numberOfBricks = transform.childCount;
        if (numberOfBricks == 0)
            {
                SceneManager.LoadScene(level);
            }
        }
}
