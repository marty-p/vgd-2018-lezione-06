using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed = 10;
    public float jumpSpeed = 10;
    public float gravity = 9.81f;

    private Vector3 movement;

    private CharacterController controller;


    // Use this for initialization
    void Start () {

        controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        if(controller.isGrounded){

            float movementH = Input.GetAxis("Horizontal");
            float movementV = Input.GetAxis("Vertical");

            movement = new Vector3(movementH, 0.0f, movementV)*speed;

            if (Input.GetButton("Jump"))
            {

                movement.y = jumpSpeed;

            }

        }

        movement.y = movement.y - (gravity*Time.deltaTime);
        controller.Move(movement*Time.deltaTime);

		
	}
}
