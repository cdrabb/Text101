using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text text;
    private enum States {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, cell_2, lock_1,
        cellblock_0, cellblock_R_0, cellblock_L_0, cellblock_D, cellblock_1, cellblock_R_1,
        cellblock_L_1, closet_0
    };
    private States myState;

	// Use this for initialization
	void Start ()
    {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(myState);
        if (myState == States.cell)
        {
            cell();
        }
        else if (myState == States.sheets_0)
        {
            sheets_0();
        }
        else if (myState == States.lock_0)
        {
            lock_0();
        }
        else if (myState == States.mirror)
        {
            mirror();
        }
        else if (myState == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myState == States.lock_1)
        {
            lock_1();
        }
        else if (myState == States.sheets_1)
        {
            sheets_1();
        }
        else if (myState == States.cell_2)
        {
            cell_2();
        }
        else if (myState == States.cellblock_0)
        {
            cellblock_0();
        }
        else if (myState == States.cellblock_R_0)
        {
            cellblock_R_0();
        }
        else if (myState == States.cellblock_L_0)
        {
            cellblock_L_0();
        }
        else if (myState == States.cellblock_D)
        {
            cellblock_D();
        }
        else if (myState == States.cellblock_1)
        {
            cellblock_1();
        }
        else if (myState == States.cellblock_R_1)
        {
            cellblock_R_1();
        }
        else if (myState == States.cellblock_L_1)
        {
            cellblock_L_1();
        }
        else if (myState == States.closet_0)
        {
            closet_0();
        }

    }

    void cell()
    {
        text.text = "You should have never trusted that girl... " +
                    "She was a con artist and she got you " +
                    "thrown in the slammer while she made off " +
                    "with all of the money. You look around your " +
                    "new home and take in the view. There is a " +
                    "tattered sheet on a brown stained mattress, " +
                    "a mirror above the toilet, and the door is locked from the outside.\n\n" +
                    "Press S to view Sheets.\n" +
                    "Press M to view Mirror.\n" + 
                    "Press L to view the Lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
    }

    void sheets_0()
    {
        text.text = "The sheets are disgusting and tattered. You move to " + 
                    "grab them, but you're pretty sure that you can see " +
                    "something moving around underneath them. You decide to leave it be.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void lock_0()
    {
        text.text = "You check the door and find that it has a standard " +
                    "prison locking mechanism. Unless you managed to sneak in a " +
                    "lockpick, there's nothing that you can do without a key.\n\n" +
                    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void mirror()
    {
        text.text = "You look at yourself in the mirror above the toilet. Your prison " +
                    "jumpsuit is a bright orange with the code B82497 written in black " +
                    "across the right side of your chest. As you look at the mirror closer, " +
                    "you notice that it is crooked and may not be as firmly attached to the wall " +
                    "as it is supposed to be.\n\n"+
                    "Press P to Pull the mirror off of the wall.\n" +
                    "Press R to Return to roaming your cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell_mirror;
        }
    }

    void cell_mirror()
    {
        text.text = "Your curiosity gets the better of you and you grab the mirror from " +
                    "either side with both hands. With a light tug, you are able to " +
                    "completely remove the mirror from the wall. Upon removing the mirror " +
                    "you find a small hidden compartment containing a gallon sized bag " +
                    "holding a strangely colored liquid. You begin to untie the bag and " +
                    "an odor reminiscent of a public bathroom and alcohol is released " + 
                    "that stings your eyes and singes your nose hairs. You recoil and " + 
                    "immediately tie the bag back up. You may be able to use this for later.\n\n" +
                    "Press S to view the Sheets.\n" +
                    "Press L to view the Lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void sheets_1()
    {
        text.text = "You look at the tattered sheets and you can clearly see that something " +
                    "is stirring beneath them. You approach the bed cautiously and quickly pull " +
                    "the sheets off of the bed. Standing on the bed is what appears to be a small " +
                    "man, no more than four inches tall, dressed in a white t-shirt, black vest, " +
                    "acid washed jeans, combat boots, and a fedora. Very stylish. He looks up at you " +
                    "and begins to speak.\n \"Hey buddy, can't you see that someone is under here?! " +
                    "You really messed up, buddy. Couldn't just leave well enough alone and serve your time?\" " +
                    "He lowered his head and shook it while laughing maniacally. \"You're buzzard food now, kid--\"\n" +
                    "You notice that the little man began to sniff the air longingly. He looks you up and down and then " +
                    "gestures to the bag of unidentified liquid you're holding in your hand.\n \"Hey, is that " +
                    "toilet wine you got there?\"\n He took a long pause and turned up his face.\n\"Look buddy, " +
                    "if you let me drink my fill of that there bag, then I'll cut you a deal that you can't refuse, okay?\"\n\n" +
                    "Press G to Give him the bag.";

        if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.cell_2;
        }
    }

    void cell_2()
    {
        text.text = "You decide to hand the bag over to the little man in hopes that he'll spare " +
                    "your life, though, you're not really sure how he could do you any sort bodily harm " +
                    "at his stature, but you'd really rather not think about it. The little man unties the " +
                    "bag and somehow manages to drink out of the bag without spilling a drop of the " + 
                    "mysterious liquid. When he was done, the bag had been depleted to about half of " + 
                    "it's original volume. How could he possibly drink so much of that vile liquid?\n " +
                    "\"Hey buddy, thanks for letting me get my fix. I'm really sorry for threatening you earlier. " +
                    "Please, take this key and get out of my cell before I rip your stupid head off.\"\n" +
                    "The small man shoots you a toothy grin and pulls a key only slightly smaller than himself " +
                    "out of what appears to be nowhere and throws over your head. You look up to catch the key " +
                    "and by the time you look back down, the little man is gone. Was he ever really there at all?\n\n" +
                    "Press L to view the Lock.";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }

    }

    void lock_1()
    {
        text.text = "You reach outside of the cell door and around to the front of the lock to determine where the " +
                    "keyhole is. After a few seconds, you find the keyhole and slip the key inside. The lock requires " +
                    "a bit of force, but you manage to turn it and unlock the door. As you try to remove the key from the " +
                    "hole it begins to disintegrate into nothing. What the hell was that key made out of? It didn't matter. " +
                    "Your cell door was unlocked and you were free to leave!\n\n" +
                    "Press O to Open the cell door.";

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.cellblock_0;
        }
    }

    void cellblock_0()
    {
        text.text = "You open the cell door and walk through the doorway into a much larger room. You examine " +
                    "the room and find that there are hundreds of cell doors just like yours, in rows, many " +
                    "tiers above and below. It was foolish of you to think that you were already home free. " +
                    "You look to your right and see words painted on to the concrete wall reading, \"CELL BLOCK B,\""+
                    "and then you hear the multiple voices approaching...\n\n" +
                    "Press R to go Right down the cell block.\n" +
                    "Press L to go Left down the cell block.\n" +
                    "Press D to look Down and examine the floor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_0;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.cellblock_L_0;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.cellblock_D;
        }
    }

    void cellblock_R_0()
    {
        text.text = "You begin to move to the right and notice that none of the cells are occupied. " +
                    "The voices are becoming louder in this direction and you cannot risk getting thrown back " +
                    "in the slammer.\n\n" +
                    "Press L to go Left down the cell block.\n" +
                    "Press D to look Down and examine the floor.";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.cellblock_L_0;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.cellblock_D;
        }
    }

    void cellblock_L_0()
    {
        text.text = "You begin to move to the left and notice that none of the cells are occupied. " +
                    "There is a small door infront of you, but you have no means of unlocking it. \n\n" +
                    "Press R to go Right down the cell block.\n" +
                    "Press D to look Down and examine the floor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_0;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.cellblock_D;
        }
    }

    void cellblock_D()
    {
        text.text = "The cellblock is dimly lit and the floor is black, making it difficult to make out any details, but " +
                    "you get down and search the floor for anything of use anyway. After a few moments of sweeping the ground " +
                    "with your hands, you feel a small metal object resembling a bobbypin.\n\n" +
                    "Press R to go Right down the cell block.\n" +
                    "Press L to go Left down the cell block.\n" +
                    "Press P to Pick up the object.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_0;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.cellblock_L_0;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cellblock_1;
        }
    }

    void cellblock_1()
    {
        text.text = "The voices keep getting louder and louder which means that they're getting closer. " +
                    "You don't seem to recognize what language they're speaking. In truth, " +
                    "you've never heard anything like it before. " +
                    "You need to find a way out of here or you're going to end up back in that cell... or worse.\n\n" +
                    "Press R to go Right down the cell block.\n" +
                    "Press L to go Left down the cell block.\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.cellblock_L_1;
        }
    }

    void cellblock_R_1()
    {
        text.text = "The voices are so close and so loud that you can feel your internal organs vibrating. " +
                    "The air is thick with dread and the smell is much like that of the liquid you're carrying. " +
                    "There is no way that you can sneak through without being noticed.\n\n" +
                    "Press L to go Left down the cell block.\n";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.cellblock_L_1;
        }
    }

    void cellblock_L_1()
    {
        text.text = "You approach a small locked door and realize you have nowhere else to go. " +
                    "The door clearly requires some sort of key, but with some doing you may be able " +
                    "to pick the lock.\n\n" +
                    "Press P to Pick the lock with your bobbypin.\n" +
                    "Press R to go Right down the cell block.\n";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.closet_0;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_1;
        }
    }

    void closet_0()
    {
        text.text = "You approach a small locked door and realize you have nowhere else to go. " +
                    "The door clearly requires some sort of key, but with some doing you may be able " +
                    "to pick the lock.\n\n" +
                    "Press P to Pick the lock with your bobbypin.\n" +
                    "Press R to go Right down the cell block.\n";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.closet_0;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cellblock_R_1;
        }
    }
}
