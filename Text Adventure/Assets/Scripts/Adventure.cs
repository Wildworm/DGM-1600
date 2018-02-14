using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    public Text text;
    public Text title;
    public bool knife;
    public bool lockpick;
    public bool doorUnlocked;
    private int sleepCounter;
    private int timeCounter;
    public enum States
    {
        Bedroom, Window, Door, Bed,
        UnderTheBed, Sleep,
        Hallway, HallLeft, HallRight,
        Fight, Run, HoleInWall,
        BigMetalDoor, ClimbFence, Gate1, ClimbFence2, Woods,
        Gate2, BackDoor, NoPolice, Police, Escape, GameOver
    };
    public States myPlace;
    public string NewGame;
    private int doorCounter;

    // Use this for initialization
    void Start()
    {
        knife = false;
        lockpick = false;
        doorUnlocked = false;
        sleepCounter = 5;
        timeCounter = 1;
        doorCounter = 0;
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
        if (timeCounter == 1)
        {
            text.text = "\nYou wake up in a bedroom. " +
                        "You are alone and your head hurts. " +
                        "\nThere is a bed, a door, and a window." +
                        "\n\nPress left to check out the bed." +
                        "\nPress up to check out the door." +
                        "\nPress right to check out the window.";

        }
        else if(timeCounter > 1)
        {
            text.text = "\nThere has to be a way out of here.... " +
                        "\n\nPress left to check out the bed." +
                        "\nPress up to check out the door." +
                        "\nPress right to check out the window.";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            timeCounter = 2;
            myPlace = States.Bed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            timeCounter = 2;
            myPlace = States.Window;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            timeCounter = 2;
            myPlace = States.Door;
        }
    }
    void Window()
    {
        if (lockpick == false)
        {
            text.text = "\nThe window is barred. Outside you can see that you are in a neighborhood somewhere." +
                        "It seems to be late afternoon." +
                        "There is a small thin metal object on the window sill." +
                        "\nTake it?" +
                        "\n\nPress up to take the Lockpick." +
                        "\nPress down to return to the middle of the Bedroom.";
        }
        else
        {
            text.text = "\nThe window is barred. Outside you can see that you are in a neighborhood somewhere." +
                        "It seems to be late afternoon." +
                        "\nPress down to return to the middle of the Bedroom.";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && lockpick == false)
        {
            lockpick = true;
            myPlace = States.Window;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myPlace = States.Bedroom;
        }
    }
    void Door()
    {
        if (lockpick == false)
        {
            text.text = "\nThe door is locked." +
                        "It appears to be made of metal." +
                        "There is a small lock." +
                        "\n\nPress down to return to the middle of the Bedroom.";
        }
        else if (doorUnlocked == true && lockpick == true && doorCounter == 1)
        {
            text.text = "The door is unlocked." +
                         "\nIt appears to be made of metal." +
                         "\n\nPress up to leave the room." +
                         "\nPress down to return to the middle of the room.";
        }
        else if (lockpick == true && doorUnlocked == false)
        {
            text.text = "The door is locked." +
                "It appears to be made of metal." +
                "There is a small lock. Maybe the metal object will fit inside?" +
                "You here a click and the door opens." +
                "\n\nPress up to leave the room." +
                "\nPress down to return to the middle of the room.";
            doorUnlocked = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            doorCounter = 1;
            myPlace = States.Bedroom;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && doorUnlocked == true)
        {
            doorCounter = 1;
            myPlace = States.Hallway;
        }
    }
    void Bed()
    {
        if (knife == false)
        {
            text.text = "Its a bare mattress." +
                        "The frame is bolted to the floor." +
                        "There seems to be something shiny under the bed." +
                        "Or maybe you can sleep?" +
                        "\n\nPress left to check Under The Bed." +
                        "\nPress right to go to Sleep." +
                        "\nPress down to return to the middle of the Bedroom.";
        }
        else if (knife == true && sleepCounter < 5)
        {
            text.text = "Its a bare mattress." +
                        "The frame is bolted to the floor." +
                        "You could always sleep some more?" +
                        "Not much else to do..." +
                        "\n\nPress right to go to Sleep." +
                        "\nPress down to return to the middle of the Bedroom.";
        }
        else if (knife == true && sleepCounter ==5)
        {
            text.text = "Its a bare mattress." +
                        "The frame is bolted to the floor." +
                        "You could always sleep?" +
                        "\n\nPress right to go to Sleep." +
                        "\nPress down to return to the middle of the Bedroom.";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && knife == false)
        {
            myPlace = States.UnderTheBed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.Sleep;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myPlace = States.Bedroom;
        }
    }
    void UnderTheBed()
    {
        text.text = "You bend down and look under the bed." +
                    "There is a rusty knife." +
                    "There is some kind of sticky substance on the blade." +
                    "\nTake it?" +
                    "\n\nPress up to take the knife." +
                    "\nPress down to return to the Bed.";
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            knife = true;
            myPlace = States.Bed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myPlace = States.Bed;
        }
    }
    void Sleep()
    {
        if (sleepCounter > 0)
        {
            text.text = "The bed seems comfy enough..." +
                        "\nLater you wake up." +
                        "You dont really feel very rested but there is food by the door." +
                        "You are kind of hungry..." +
                        "You go ahead and eat the food." +
                        "You've had worse..." +
                        "\n\nPres space to continue.";

            if (Input.GetKeyDown(KeyCode.Space))
            {
                sleepCounter = sleepCounter - 1;
                myPlace = States.Bedroom;
            }
        }
        else if (sleepCounter == 0)
        {
            title.text = "YOU DIED";
            text.text = "You wake up and there is a person standing over you." +
                        "You feel a sharp pain in your chest and then the lights go out." +                       
                        "\n\nPress Space to continue.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(NewGame);
            }
        }
    }
    void Hallway()
    {
        title.text = "I really hope no one is home";

        text.text = "Outside the door is a long hallway stretching off to the left and the right?" +
                    "Press left to go left down the hall." +
                    "\n\nPress right to go right down the hall." +
                    "\nPress left to go left down the hall." +
                    "\nPress down to return to the Bedroom.";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.HallLeft;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.HallRight;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myPlace = States.Bedroom;
        }
    }
    void HallLeft()
    {
        text.text = "As you head left down the hallway you quickly come to a corner." +
                    "Peering down the dimly lit hall, you can clearly see it dead end." +
                    "Mom must have been right about your sense of direction." +
                    "\n\nPress down to return to the middle of the Hallway.";

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myPlace = States.Hallway;
        }

    }
    void HallRight()
    {
        title.text = "This is bad";

        text.text = "As you make your way down the hallway, you notice that there are less an less lights on the wall as you go." +
                "Soon you're stumbling along in pure darkness..." +
                "\n\nThen with a bright flash the hallway is illuminated and before you stands a person in a creepy smiling mask." +
                "And he is holding a rather large bat." +
                "Laughter echos down the hall, but not from them." +
                "The laughter is coming from you..." +
                "Or are you crying?" +
                "\n\nPress left to stand and fight." +
                "\nPress right to run.";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.Fight;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.Run;
        }

    }
    void Fight()
    {
        if (knife == false)
        {
            title.text = "YOU DIED";
            text.text = "\nYou charge at the masked kidnapper hoping to be able to take the bat from them." +
                        "But as you approach, the lights go out once more and you feel a massive impact against the side of your head." +
                        "Then all the lights go out." +
                        "\n\nPress Space to Restart.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(NewGame);
            }
        }
        else if (knife == true)
        {
            title.text = "YOU DIED";
            text.text = "Suddenly you remember the knife in your pocket, and you charge at the masked kidnapper." +
                        "Screaming like a banshee you swing the knife like a maniac at the kidnapper." +
                        "With surprise you feel the knife sink into their body and get stuck." +
                        "They laugh and then the lights go out." +
                        "\n\nPress Space to restart.";
    }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }
    }
    void Run()
    {
        title.text = "Run, Run, Run, Jump!";
        text.text = "\nThe moment you see your kidnapper something instinctual sends you fleeing back down the hallway." +
                    "As you run you see things you couldnt notice in the dark." +
                    "A large hole in the wall and a big Metal Door." +
                    "\n\nPress left to go into the hole in the wall." +
                    "\nPress right to go through the big metal door";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.HoleInWall;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.BigMetalDoor;
        }
    }
    void HoleInWall()
    {
        text.text = "\nWithout slowing down you charge through this strange hole. Its pitch black inside but that doesnt slow you down." +
                    "After a few minutes that feel like eternity you see a light at the end." +
                    "You rush into the light and tears start to stream down your face.You've made it out!!" +
                    "As your eyes adjust to the light you realize one key problem." +
                    "Your in the backyard and there is a really large fence in between you and your freedom." +
                    "Looking aroung you also see a gate off to the side of the house." +
                    "\n\nPress Left to climb the fence." + 
                    "\nPress Right to go through the gate.";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.ClimbFence;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.Gate1;
        }
    }
    void BigMetalDoor()
    {
        text.text = "You whip out that handy lockpick you used earlier and manage to quickly pick the lock. You hurry inside and slam the door behind you, hoping that it locks automatically." + 
                    "You hear what sounds like it locking and part of you relaxes. As you turn and look at where you are now, you realize the worst.You are back in that horrid bedroom." +
                    "Your heart freezes as you hear a the most wicked laugh. Then the lights go out, or maybe that was you?" +
                    "\n\nPress Space to restart.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }
    }
    void ClimbFence()
    {
        text.text = "With no time to spare you bolt towards the fence and leap at it." +
                    "Hoping you can just get your hands to the top and pull you up." +
                    "Just barely you feel your fingertips connect with the top of the fence." +
                    "With more desperation than strength, you manage to pull yourself up and over." +
                    "You land in the neighboors yard. You see their gate, but maybe they are home?" +
                    "Or maybe you will just climb another fence..." +
                    "\n\nPress left to use the gate." +
                    "\nPress up to go to the back door." +
                    "\nPress right to climb their fence too.";

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myPlace = States.Gate2;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myPlace = States.ClimbFence2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myPlace = States.BackDoor;
        }
    }
    void Gate1()
    {
        title.text = "YOU DIED";
        text.text = "You rush around the house hoping to see a gate." +
                    "There it is!" +
                    "Like a mad man you run towards it and swing it open..." +
                    "\nThere stands your kidnapper. You try to scream, but you just don't have anything left." +
                    "You fall to the ground and feel yourself begin to give up on ever escaping. Then the lights go out." +
                    "\n\nPress Space to restart";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }

    }
    void Gate2()
    {
        title.text = "YOU DIED";
        text.text = "You go for the gate. If only you can make it to the street, then you'll be free." +
                    "You swing the gate open quickly and there stands your kidnapper." +
                    "You try to scream, but you just don't have anything left." +
                    "You fall to the ground and feel yourself begin to give up on ever escaping. Then the lights go out." +
                    "\n\nPress Spcae to restart.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }

    }
    void ClimbFence2()
    {
        title.text = "Should have looked first";
        text.text = "One fence wasn't far enough. You suspect the neighbors must be in on it." +
                    "You quickly climb over the next fence without even checking to see what is on the other side." +
                    "As you drop down, you realize too late that whats below you isn't another yard, but a steep downward slope." + 
                    "As you roll down the hill you feel an impact on your head." +
                    "\n\nPress Spcae to continue.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPlace = States.Woods;
        }

    }
    void Woods()
    {
        title.text = "YOU DIED";
        text.text = "Slowly you come around. Once again your head hurts, but at least you arent in a room." +
                    "You begin to take stock of your surroundings. Its dark, and it appears you are in a wooded are of some sort." +
                    "There is a light off to your right. As you make your way towards it a shadow appears beside you." +
                    "As you turn to face it, your world starts spinning and all the lights go out." +
                    "\n\nPress Spcae to restart.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }

    }
    void BackDoor()
    {
        title.text = "Please be home";
        text.text = "You race for the back door of the house. You attempt to open it, but its locked!" +
                    "You bang on the door rapidly, screaming for them to open it and let you in." + 
                    "\n\"PLEASE, HELP ME!!\"" +
                    "\nWithout warning you feel the door give way and you collapse onto the floor inside." +
                    "You look up and you see the kind face of an older man." +
                    "He helps you up and as you explain you story he calls the police for you." +
                    "\n\nPress Spcae to continue.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPlace = States.Police;
        }

    }
    void Police()
    {
        title.text = "I really hope I'm not dreaming";
        text.text = "One glass of water and one of his wife's cookies later, you hear the sirens out front and see the flashing lights." +
                    "Finally the police are here." +
                    "Once again you tell you story, but you are a bit more together this time." +
                    "Some of them go next door to check out the other house." +
                    "While one officer stays with you and escorts you to a police car." +
                    "\n\nPress Spcae to continue." ;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myPlace = States.Escape;
        }
    }
    void Escape()
    {
        title.text = "You escaped?";
        text.text = "As they help you get in the back of the car you look up to see them smiling down at you." +
                    "But something seems off about that smile..." +
                    "You shrug it off and the car pulls away from the house, headed for anyplace but here." +
                    "\n\nPress Spcae to restart.";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NewGame);
        }

    }

}

