using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    enum State{
        WalkDown,
        WalkUp,
        WalkLeft,
        WalkRight,
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
            state = State.WalkRight;
            moving = true;

        } if (Input.GetKey("a"))
        {

            velocity = new Vector2(-1, 0) + velocity;
            state = State.WalkLeft;
            moving = true;


        } if (Input.GetKey("w"))
        {

            velocity = new Vector2(0, 1) + velocity;
            state = State.WalkUp;
            moving = true;


        } if (Input.GetKey("s"))
        {

            velocity = new Vector2(0, -1) + velocity;
            state = State.WalkDown;
            moving = true;

        } if (!moving) {
            state = State.Idle;
        }

        animator.SetBool("is_walk_down", false);
        animator.SetBool("is_walk_up", false);
        animator.SetBool("is_walk_left", false);
        animator.SetBool("is_walk_right", false);


        if (state == State.WalkDown){
                animator.SetBool("is_walk_down", true);
        } else if (state == State.WalkUp){
                animator.SetBool("is_walk_up", true);
        } else if (state == State.WalkRight){
                animator.SetBool("is_walk_right", true);
        } else if (state == State.WalkLeft){
                animator.SetBool("is_walk_left", true);
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

        rigidbody2d.MovePosition(rigidbody2d.position + (velocity * SPEED) * Time.deltaTime);

    }
}