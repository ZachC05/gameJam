using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float playerSpeed;
    public float playerRotateSpeed;


    [Header("Player Interacts")]
    public GameObject playerInteractBox;
    public float interactRadius;
    public LayerMask interactables;

    [Header("Player Keybinds")]
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public KeyCode Interact;

    private Rigidbody rb;
    private Transform t;

    // Start is called before the first frame update
    void Start()
    {
        //get rigid body and transform
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the inputs
        Inputs();
    }

    private void FixedUpdate()
    {
        Physics.OverlapSphere(playerInteractBox.transform.position, interactRadius, interactables);
    }

    private void Inputs()
    {
        //Forward Input
        if (Input.GetKey(moveForward))
        {
            Move(transform.forward, playerSpeed);

            //changes the direction the player is facing
        }
        //Right Input
        if (Input.GetKey(moveRight))
        {
            Move(transform.right, playerSpeed);

            //changes the direction the player is facing
        }
        //Left Input
        if (Input.GetKey(moveLeft))
        {
            Move(transform.right, -playerSpeed);

            //changes the direction the player is facing
        }
        //Back Input
        if (Input.GetKey(moveBackward))
        {
            Move(transform.forward, -playerSpeed);

            //changes the direction the player is facing
        }
    }


    //allows the player to move
    private void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);
    }

    private void RotateTowards(float turnspeed)
    {
        t.Rotate(0, turnspeed * Time.deltaTime, 0);
    }
}
