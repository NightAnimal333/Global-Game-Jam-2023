using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float progress;
    public GameObject minigame;

    public ProgressBar progressBar;

    public GameObject library;

    public Dictionary<string, bool> flags;

    // Start is called before the first frame update
    void Start()
    {

        flags = new Dictionary<string, bool>();
        flags.Add("newspaper_solved", false);

        minigame.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNewspaper(){

        minigame.SetActive(true);

        progressBar.IncreaseKnowledge(50);

        library.SetActive(true);

    }

    public void PlayLibrary(){

        //library.SetActive(false);

        progressBar.IncreaseKnowledge(50);

    }
}
