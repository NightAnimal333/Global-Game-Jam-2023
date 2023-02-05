using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float progress;
    public GameObject minigame;

    public ProgressBar progressBar;

    public GameObject library;

    public InteractObjectGrillDude grillDude;

    public Dictionary<string, bool> flags;

    private bool libraryActive = false;

    // Start is called before the first frame update
    void Start()
    {

        flags = new Dictionary<string, bool>();
        flags.Add("newspaper_solved", false);
        flags.Add("gibberish", false);


        minigame.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (libraryActive){
            return;
        }

        if (flags["gibberish"] && flags["newspaper_solved"]){
            library.SetActive(true);
            libraryActive = true;
        }
        
    }

    public void PlayNewspaper(){

        minigame.SetActive(true);

        progressBar.IncreaseKnowledge(25);

    }

    public void PlayLibrary(){

        //library.SetActive(false);

        progressBar.IncreaseKnowledge(25);

        grillDude.GetUnderstanding();

    }

    public void PlayKidGibberish(){

        
        //library.SetActive(true);

        progressBar.IncreaseKnowledge(25);

    }

    public void PlayKidRealTalk(){

        progressBar.IncreaseKnowledge(25);

    }
}
