using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndingController : MonoBehaviour
{
    // Start is called before the first frame update
    string EndingScript;
    public TMP_Text EndingText;
    void Start()
    {
       GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        EndingScript = "Congratulations! You have beaten Chapter 1 of Flumen Apocalypta!  \u000a Your party includes " + gm.Companions() + " \u000a \u000a With your ship fully upgraded, your ship has truly bested the dangerous river... for now.  \u000a \u000a Unfortunately, the river has reached a boiling point. Will you help the corporate heads of the Metronomicon, the rebel refugees holed up in Louistown, the rising Kingdom of Memphis, or Dr. Moroe's quest to burn it all to the ground?  \u000a From now on, all of your actions will have deadly consequences.";
        EndingScript += " \u000a  \u000a Thanks for Playing Chapter 1! I hope you had fun with this beta version of what will hopefully become a much more fully realized RPG. I plan on adding a couple more companions and full questlines for each of them, as well as 5 major faction storylines to choose from. This game is born for love of my home state and the importance the Mississippi river has had to people for centuries. Even though the governments of my state, and many in the south have started a vitriolic war on trans people, I want to showcase that trans people will always persist in the South, even when the world seems over. This game is a love letter to every trans person in the South, and I hope people find enjoyment from the world of Flumen Apocalypta.";
        EndingScript += " \u000a  \u000a Credits: Created by Radha Hosad. Artwork: Artist's impression of the Thimble Tickle specimen found on 2 November 1878, which reportedly measured 55 feet (17 m) in total length, from Charles Frederick Holder's Marvels of Animal Life (Holder, 1885:198, pl. 25). Lake George, Free Study by John Frederick Kenset";
        EndingScript += " \n \n Pirate Sprites based on design by DezrasDragons from OpenGameArt.Wooden ship tiles by Tuomo Untinen. Tilemap by [LPC] Overworld by Benjamin K. Smith, commissioned by castelonia. Grass/Water based on tiles by Lanea Zimmerman (AKA Sharm). Sand/Snow based on tiles by Daniel Eddeland, William.ThompsonJ, Nushio, and Adrix89. Pirate Ship by David Harrington from OpenGameArt. 'Convincing Pirate' by Walter E Stewart courtesy of Dafont";
    }

    // Update is called once per frame
    void Update()
    {
        EndingText.text = EndingScript;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void NewGamePlus()
    {
        SceneManager.LoadScene("Boat");
    }
}
