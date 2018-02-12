using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    public Text text;
    public Text title;

    public enum States
    {
        Bedroom, Window, Door, Bed,
        UnderTheBed, Sleep,
        Hallway, HallLeft, HallRight,
        Fight, FightKnife, Run, HoleInWall,
        BigMetalDoor, ClimbFence, Gate1, ClimbFence2, Woods,
        Gate2, BackDoor, NoPolice, Police, Escape
    };
    public States myPlace;

    // Use this for initialization
    void Start()
    {
        myPlace = States.Bedroom;

    }
    void Update()
    {
        if (myPlace == States.Bedroom)
        {
            Bedroom();
        }
        else if (myPlace == States.Window)
        {
            Window();
        }
        else if (myPlace == States.Door)
        {
            Door();
        }
        else if (myPlace == States.Bed)
        {
            Bed();
        }
        else if (myPlace == States.UnderTheBed)
        {
            UnderTheBed();
        }
        else if (myPlace == States.Sleep)
        {
            Sleep();
        }
        else if (myPlace == States.Hallway)
        {
            Hallway();
        }
        else if (myPlace == States.HallLeft)
        {
            HallLeft();
        }
        else if (myPlace == States.HallRight)
        {
            HallRight();
        }
        else if (myPlace == States.Fight)
        {
            Fight();
        }
        else if (myPlace == States.FightKnife)
        {
            FightKnife();
        }
        else if (myPlace == States.Run)
        {
            Run();
        }
        else if (myPlace == States.HoleInWall)
        {
            HoleInWall();
        }
        else if (myPlace == States.BigMetalDoor)
        {
            BigMetalDoor();
        }
        else if (myPlace == States.ClimbFence)
        {
            ClimbFence();
        }
        else if (myPlace == States.Gate1)
        {
            Gate1();
        }
        else if (myPlace == States.Gate2)
        {
            Gate2();
        }
        else if (myPlace == States.ClimbFence2)
        {
            ClimbFence2();
        }
        else if (myPlace == States.Woods)
        {
            Woods();
        }
        else if (myPlace == States.BackDoor)
        {
            BackDoor();
        }
        else if (myPlace == States.Police)
        {
            Police();
        }
        else if (myPlace == States.Escape)
        {
            Escape();
        }

    }
    void Bedroom()
    {
        title.text = "Where Am I?";

        text.text = "\n\nYou wake up in a bedroom. "+
            "\nYou are alone and your head hurts. "+
            "\nThere is a Bed, a Door, and a Window."+
            "\nPress left to check out the bed. \n Press up to check out the door. \nPress right to check out the window.";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.Bed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.Door;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myPlace = States.Window;
        }
    }
    void Window()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Door()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Bed()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void UnderTheBed()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Sleep()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Hallway()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void HallLeft()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void HallRight()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Fight()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void FightKnife()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Run()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void HoleInWall()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void BigMetalDoor()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void ClimbFence()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Gate1()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Gate2()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void ClimbFence2()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Woods()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void BackDoor()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Police()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }
    void Escape()
    {
        text.text = "";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
    }

}

