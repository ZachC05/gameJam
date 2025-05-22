using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float playerSpeed;
    public float playerRotateSpeed;


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

    private void Inputs()
    {
        //Forward Input
        if (Input.GetKey(KeyCode.W))
        {
            Move(transform.forward, playerSpeed);



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
