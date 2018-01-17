using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    bool winCondition = false;
    public int maxGuesses;
    public int max;
    public int min;
    int guess;

    // Use this for initialization
    private void Start() {

        print("Welcome to... \n\tNumber Guesser!");
        print("Pick a number between " + min + " and " + max + "!");


        guess = Random.Range(400, 600);

        //Is the value Guess
        print("Is the number " + guess + "?");

        //instructions - push these buttons
        print("Press the up arrow if your number is higher \n the down arrow if your number is lower, \n and enter if I'm correct.");
        
    }
	
	// Update is called once per frame
	public void Update() {
        if (winCondition == true)
        {
            print("I win! Thanks for playing!");
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess + 1;
            guess = Random.Range(min, max);
            print("Is the number " + guess + "?");

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            guess = Random.Range(min, max);
            print("Is the number " + guess + "?");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            winCondition = true;
        }
    }
}
