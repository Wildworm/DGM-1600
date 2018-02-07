using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int maxGuesses;
    public int max;
    public int min;
    int guess;
    int count;

    // Use this for initialization
    private void Start() {
        max = max + 1;

        print("Welcome to... \n\tNumber Guesser!");
        print("Pick a number between " + min + " and " + max + "!");

        //Is the value Guess
        Guess(count);
        

        //instructions - push these buttons
        print("Press the up arrow if your number is higher \n the down arrow if your number is lower, \n and enter if I'm correct.");

        
    }

    private void Guess(int count)
    {
        if (count == maxGuesses)
        {
            print("Well... \nyou win...");
            Application.Quit();
        }
        else
        {
            guess = Random.Range(min, max);
            print("Is the number " + guess + "?");
        }
    }

	
	// Update is called once per frame
	public void Update() {

        //Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("YOU LOSE!");
            Application.Quit();
        }
        //up arrow
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            count = count + 1;
            min = guess + 1;

            Guess(count);
           
        }

        //Down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            count = count + 1;
            max = guess - 1;
            Guess(count);
           
        }
    }
}
