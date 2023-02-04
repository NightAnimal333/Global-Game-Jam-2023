using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPuzzlePiece : MonoBehaviour
{

    public pieceRotation pr;
    GameObject currentPiece;

    
    
    //public GameObject corner1, corner2, corner3, corner4;

    // Start is called before the first frame update
    void Start()
    {
        currentPiece = GameObject.Find("corner1");

        //GetComponent<Transform>().rotation(70);
        //test.Rotate(vector);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Current: " + currentPiece.name);

    }

    void OnMouseDown()
    {
        print("ON MOUSE CLICK");
        if (Input.GetMouseButtonDown(0))
        {
            print("left click");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit)
            {
                print("found coll");
                
                currentPiece = GameObject.Find(hit.collider.gameObject.name);
                
                if (currentPiece != null)
                {
                    pr.currentPiece = currentPiece;
                    
                }
            }
        }
    }
}
