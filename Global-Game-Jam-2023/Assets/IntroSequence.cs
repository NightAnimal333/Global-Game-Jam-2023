using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    public GameObject character;
    public GameObject mainCamera;
    public Vector3 destination;
    public float sequenceDuration;

    private float elapsedTime;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {

        elapsedTime = 0;
        startPosition = gameObject.transform.position;

        character.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        elapsedTime += Time.deltaTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, destination, (elapsedTime/sequenceDuration));

        if (elapsedTime > sequenceDuration){
            mainCamera.transform.parent = character.transform;
            mainCamera.transform.localPosition = new Vector3(0, 0, -10);

            character.SetActive(true);
        }
        
    }
}
