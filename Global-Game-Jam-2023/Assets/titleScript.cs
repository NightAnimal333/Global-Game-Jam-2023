using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleScript : MonoBehaviour
{

    public GameObject letterCanvas;
    public AudioSource LetterSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("space"))
        {
            letterCanvas.SetActive(true);
            Destroy(gameObject);

        if(letterCanvas == true)
        {
            PlaySound();

        }

        } 
    }

    public void PlaySound()
    {
        LetterSound.Play();
    }
}
