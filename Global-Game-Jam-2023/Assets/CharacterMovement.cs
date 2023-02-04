using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    enum State{
        WalkForward,
        Idle
    }

    public float SPEED;

    // External object references
    public Animator animator;
    public Rigidbody2D rigidbody2d;


    // Internal variables
    private State state;
    private State oldState;

    private Vector2 velocity;


    // Start is called before the first frame update
    void Start()
    {
        state = State.Idle;
    }

    // Update is called once per frame
    void Update()
    {

        velocity = new Vector2(0, 0);

        oldState = state;

        bool moving = false; // This is trash code I am sorry
        if (Input.GetKey("d"))
        {

            velocity = new Vector2(1, 0) + velocity;
            state = State.WalkForward;
            moving = true;

        } if (Input.GetKey("a"))
        {

            velocity = new Vector2(-1, 0) + velocity;
            state = State.WalkForward;
            moving = true;


        } if (Input.GetKey("w"))
        {

            velocity = new Vector2(0, 1) + velocity;
            state = State.WalkForward;
            moving = true;


        } if (Input.GetKey("s"))
        {

            velocity = new Vector2(0, -1) + velocity;
            state = State.WalkForward;
            moving = true;

        } if (!moving) {
            state = State.Idle;
        }

        if (state == State.WalkForward){
                animator.SetBool("is_walk_forward", true);
            } else {
                animator.SetBool("is_walk_forward", false);
        }
        // if (oldState != state){

        //     if (state == State.WalkForward){
        //         animator.SetBool("is_walk_forward", true);
        //     } else {
        //         animator.SetBool("is_walk_forward", false);
        //     }

        // }
    }

    void FixedUpdate(){

        Debug.Log(velocity);
        rigidbody2d.MovePosition(rigidbody2d.position + (velocity * SPEED) * Time.deltaTime);

    }
}
