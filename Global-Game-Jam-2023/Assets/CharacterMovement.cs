using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    enum State{
        WalkForward,
        Idle
    }

    // External object references
    public Animator animator;

    // Internal variables
    private State state;
    private State oldState;


    // Start is called before the first frame update
    void Start()
    {
        state = State.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        oldState = state;
        if (Input.GetKeyDown("w"))
        {

            state = State.WalkForward;

        } else if (Input.GetKeyDown("s"))
        {

            state = State.WalkForward;


        } else if (Input.GetKeyDown("a"))
        {

            state = State.WalkForward;


        } else if (Input.GetKeyDown("d"))
        {

            state = State.WalkForward;

        } else {
            state = State.Idle;
        }

        Debug.Log(state);
        if (oldState != state){

            if (state == State.WalkForward){
                animator.SetBool("is_walk_forward", true);
            } else {
                animator.SetBool("is_walk_forward", false);
            }

        }
    }
}
