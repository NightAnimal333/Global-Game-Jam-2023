using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;





    // Start is called before the first frame update
    void Start()
    {
        //find component on game object
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip; //can change sound 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     //When player enters collision 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //REPLACE "Player" with actual PlayerOject
        if (collision.gameObject.name.Equals("Character"))
        {
            //Interact allowed becomes true = object active
            PlaySound();
        }
    }
  
    //When player exits collision
    private void OnTriggerExit2D(Collider2D collision)
    {
        //REPLACE "Player" with actual PlayerOject
        if (collision.gameObject.name.Equals("Character"))
        {
            //InteractAllowed becomes false = object NOT active
             audioSource.enabled = !audioSource.enabled;

        }

    }


    //Play sound
    private void PlaySound()
    {
    
    //Could probably insert MiniGame trigger here?

    //Placeholder code

        audioSource.Play();

    }
}
