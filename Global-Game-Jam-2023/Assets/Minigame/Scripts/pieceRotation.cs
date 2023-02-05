using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieceRotation : MonoBehaviour
{
    Vector3 vector1 = new Vector3(0, 0, -90);
    Vector3 vector2 = new Vector3(0, 0, 90);
    public GameObject currentPiece;
    public AudioSource SolvedSound;


    public GameManager gameManager;

    public List<GameObject> corners;

    // bool c1 = false,
    //      c2 = false,
    //      c3 = false,
    //      c4 = false;

    bool isSolved = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if(c1 && c2 && c3 && c4)
        if (isSolved)
        {
            //isSolved = true;
            //print("Is done!");
            //print(gameManager.flags["newspaper_solved"]);
            gameManager.flags["newspaper_solved"] = true;
            //print(gameManager.flags["newspaper_solved"]);

            Destroy(gameObject.transform.parent.gameObject, 1);

        if(currentPiece == true)
        {
            SolvedSound.Play();

        }


        }else
        {
            if (Input.GetKeyDown("right"))
            {
                currentPiece.transform.Rotate(vector1);
                print("turn right");

                // if (currentPiece.transform.rotation.z == 0)
                // {
                //     switch(currentPiece.name)
                //     {
                //         case "corner1":
                //             c1 = true;
                //             break;
                //         case "corner2":
                //             c2 = true;
                //             break;
                //         case "corner3":
                //             c3 = true;
                //             break;
                //         case "corner4":
                //             c4 = true;
                //             break;
                //     }

                // }


            }
            else if (Input.GetKeyDown("left"))
            {
                currentPiece.transform.Rotate(vector2);
                print("turn left");

                // if (currentPiece.transform.rotation.z == 0)
                // {
                //     switch(currentPiece.name)
                //         {
                //             case "corner1":
                //                 c1 = true;
                //                 break;
                //             case "corner2":
                //                 c2 = true;
                //                 break;
                //             case "corner3":
                //                 c3 = true;
                //                 break;
                //             case "corner4":
                //                 c4 = true;
                //                 break;
                //         }
                    

                //     }
                // }
        }
        
        isSolved = true;

        foreach (GameObject corner in corners)
        {
            if (corner.transform.rotation.z != 0){
                isSolved = false;
                break;
            }
        }

        
    }
}

//Play sound
public void PlaySound()
{
    SolvedSound.Play();
        
}

}
