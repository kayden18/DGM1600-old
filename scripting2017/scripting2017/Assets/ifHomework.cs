using UnityEngine;
using System.Collections;


public class ifHomework : MonoBehaviour {

	// Use this for initialization
	void Start () {
        switch (powers)
        {
            case speed:
                print("You have super speed.");
                break;
            case strength:
                print("You have super strength.");
                break;
            case flight:
                print("You can fly.");
                break;
            default:
                print("You have nothing puny human.");
                break;
        }
        switch (fruit)
        {
            case apple:
                print("You have an apple. Keep those doctors away.");
                break;
            case orange:
                print("Great an orange... you have a fruit that ryhms with nothing.");
                break;
            case banana:
                print("Yay bananas!");
                break;
            default:
                print("No fruit for you.");
                break;
        }
        switch (car)
        {
            case mustange:
                print("Cool you have a mustange.");
                break;
            case ferrari:
                print("Nice a ferrari.");
                break;
            case lamborghini:
                print("Wish i had a lambo too.");
                break;
            default:
                print("Enjoy your " + car);
                break;
        }
        switch (weapon)
        {
            case bow:
                print("Your weaopn is a bow.");
                break;
            case bat:
                print("Bat added to your inventory");
                break;
            case rocketlauncher:
                print("Go blow something up with your new rocket launcher");
                break;
            default:
                print("Enjoy your new " + weapon);
                break;
        }
        switch (color)
        {
            case Red:
                print("yay Red");
                break;
            case blue:
                print("Too Blue");
                break;
            case green:
                print("Green with envy");
                break;
            default:
                print("This color doesn't matter.");
                break;
        }
        switch (computer)
        {
            case windows:
                print("congrates you're using windows");
                break;
            case Mac:
                print("Too bad you're using ios");
                break;
            default:
                print("You're using a what?");
                break;
        }
        switch (gamingPlats)
        {
            case Microsoft:
                print("Enjoy your xbox.");
                break;
            case Sony:
                print("PS for life");
                break;
            case nintendo:
                print("Stop making consoles nintendo");
                break;
            case pc:
                print("Master race PC.");
                break;
            default:
                print("What are you using?");
                break;
        }
        switch (shoes)
        {
            case sandles:
                print("Cool snadels, take off the socks.");
                break;
            case sneakers:
                print("why do sneakers squeek");
                break;
            default:
                print("Throw away the crocs");
                break;
        }
        switch (nerds)
        {
            case starwars:
                print("may the force be with you");
                break;
            case startreck:
                print("beam me up");
                break;
            default:
                print("Lets watch them fight");
                break;
        }
        switch (fastfood)
        {
            case McDs:
                print("You're loving it");
                break;
            case BK:
                print("Watch out for the king");
                break;
            case wendys:
                print("fries and shake");
                break;
            default:
                print("Go away jackinthebox");
                break;
        }

    }
}
