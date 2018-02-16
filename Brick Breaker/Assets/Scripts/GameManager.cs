using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameManager instance = null;
    public int numberOfBricks;
    public string level;

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    void Update()
    {
        if (numberOfBricks == 0)
        {
            SceneManager.LoadScene(level);
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);


        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

    }
}
