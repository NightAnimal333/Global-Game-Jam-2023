using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/**
HOW TO USE
1. Replace "Placeholder" in the trigger methods with the name of the player Object
2. Make sure to have a canvas set on World Space with a TextMesh attached, make sure its called "InteractText"
3. Add script component to objects you want the player to interact with, make sure it has Box collider 2D set on Is Trigger
4. Make sure player has Circle Collider 2D and box collider 2d with box collider on Is Trigger
**/

public class InteractObjectGrillDude : MonoBehaviour
{

    public GameObject dialogueCanvas;
    public GameManager gameManager;

    public TextMeshProUGUI text;
    public TextMeshProUGUI button;

    private bool InteractAllowed; 
    [SerializeField] private TMP_Text InteractText;

    private bool understood = false;
    private bool interacted = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        InteractText.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (InteractAllowed && Input.GetKeyDown(KeyCode.E))
            Interact(); //Interact method
    }

    //When player enters collision 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //REPLACE "Player" with actual PlayerOject
        if (collision.gameObject.name.Equals("Character"))
        {
            //Interact allowed becomes true = object active
            InteractText.gameObject.SetActive(true);
            InteractAllowed = true;
        }
    }
  
    //When player exits collision
    private void OnTriggerExit2D(Collider2D collision)
    {
        //REPLACE "Player" with actual PlayerOject
        if (collision.gameObject.name.Equals("Character"))
        {
            //InteractAllowed becomes false = object NOT active
            InteractText.gameObject.SetActive(false);
            InteractAllowed = false;
        }

    }

    //if interact allows, then this method happens
    protected void Interact()
    {


        dialogueCanvas.SetActive(true);

        if (!understood){
            if (!interacted){
                interacted = true;
                gameManager.PlayKidGibberish();
                gameManager.flags["gibberish"] = true;
            }
        } else {
            gameManager.PlayKidRealTalk();
            Destroy(gameObject);
        }


    
        //Could probably insert MiniGame trigger here?

        //Placeholder code
        //Destroy(gameObject);
        Debug.Log("I am parent class");

    }

    public void GetUnderstanding(){

        understood = true;

        text.text = "Hello, I am Kevin. Who are you? Welcome to our community!";
        button.text = "I feel welcome here!";

    }
}
