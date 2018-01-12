using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public bool winCondition = false;
    public int max;
    public int min;
    public int guess;

    // Use this for initialization
    private void Start() {

        print("Welcome to... \n\tNumber Guesser!");
        print("Pick a number between " + min + " and " + max + "!");

        //Is the value Guess
        print("Is the value" + guess + "?");

        //instructions - push these buttons
        print("Press the up arrow if your number is higher \n the down arrow if your number is lower, \n and enter if I'm correct.");
        
    }
	
	// Update is called once per frame
	public void Update() {
        if (winCondition == true)
        {
            print("I win! Thanks for playing!");
        }
	}
}
