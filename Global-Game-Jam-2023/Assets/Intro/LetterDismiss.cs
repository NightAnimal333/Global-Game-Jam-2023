using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterDismiss : MonoBehaviour
{
    public IntroSequence intro;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        intro.started = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        Debug.Log("HALLO BABY");
        intro.PlayIntro();
        canvas.enabled = false;
    }
}
