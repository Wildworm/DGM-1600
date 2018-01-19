using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int maxGuesses;
    public int max;
    public int min;
    int guess;
    int count = 1;

    // Use this for initialization
    private void Start() {

        print("Welcome to... \n\tNumber Guesser!");
        print("Pick a number between " + min + " and " + max + "!");

        //Is the value Guess
        Guess(count);
        count = count++;

        //instructions - push these buttons
        print("Press the up arrow if your number is higher \n the down arrow if your number is lower, \n and enter if I'm correct.");

        max = max + 1;
    }

    private void Guess(int count)
    {
        if (count == 1)
            guess = Random.Range(400, 600);
        else
            guess = Random.Range(min, max);

        print("Is the number " + guess + "?");
        print(count);
    }
    //count variable broken**************************
	
	// Update is called once per frame
	public void Update() {

        if (count == maxGuesses)
        {
            print("Well... \nyou win...");
            Application.Quit();
        }
        //Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("YOU LOSE!");
            Application.Quit();
        }
        //up arrow
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess + 1;
            count = count++;
            Guess(count);
           
        }

        //Down arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            count = count++;
            Guess(count);
           
        }
    }
}
