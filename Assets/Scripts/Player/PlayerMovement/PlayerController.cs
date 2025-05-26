using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float playerSpeed;
    public float playerRotateSpeed;

    [Header("Player Sprite")]
    public GameObject PlayerRender;

    [Header("Player Animations")]
    public Animator turnAnimator;

    [Header("Player Interacts")]
    public GameObject playerInteractBox;
    public float interactRadius;
    public LayerMask interactables;
    public bool playerInTalk;

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
        //Gets the inputs unless the player is talking
        if (!playerInTalk)
        {
            Inputs();
        }

    }

    private void FixedUpdate()
    {
        
    }

    private void Inputs()
    {
        //Forward Input
        if (Input.GetKey(moveForward))
        {
            Move(transform.forward, playerSpeed);

            turnAnimator.SetBool("facingForward", true);
        }
        //Right Input
        if (Input.GetKey(moveRight))
        {
            Move(transform.right, playerSpeed);
        }
        //Left Input
        if (Input.GetKey(moveLeft))
        {
            Move(transform.right, -playerSpeed);
        }
        //Back Input
        if (Input.GetKey(moveBackward))
        {
            Move(transform.forward, -playerSpeed);

            //changes the direction the player is facing
            turnAnimator.SetBool("facingForward", false);
        }

        //interation input
        if (Input.GetKey(Interact))
        {
           bool checkForInteract = Physics.CheckSphere(playerInteractBox.transform.position, interactRadius, interactables);
            if (checkForInteract)
            {
                GameObject npc;


                Collider[] hits = Physics.OverlapSphere(playerInteractBox.transform.position, interactRadius, interactables);

                foreach (Collider hit in hits)
                {
                    npc = hit.gameObject;

                    NPCInteract NPCI = npc.gameObject.GetComponent<NPCInteract>();

                    NPCI.NPCTalk();

                    playerInTalk = true;
                }

                

            } 
        }
    }


    //allows the player to move
    private void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(playerInteractBox.transform.position, interactRadius);
    }
}
