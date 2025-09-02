using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScriptsNFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player Stuff")]
    public GameObject player;

    [Header("UI Stuff")]
    public Animator uiTextAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTalkLeave()
    {
        player.GetComponent<PlayerController>().playerInTalk = false;
        uiTextAnimator.SetBool("IsTalking", false);

    }

    //Hiiiiii hope you are having a great day :p
    //Public void to exit the game
    public void quitApplication()
    {
        Application.Quit();
    }
}
