using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteract : MonoBehaviour
{
    [Header("NPC UI")]
    public Image notification;

    [Header("UniversalUI UI")]
    public TextMeshProUGUI universalTalk;
    public Animator uiTextAnimation;

    private void Start()
    {
        notification.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "playerInteract")
        {
            notification.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "playerInteract")
        {
            notification.gameObject.SetActive(false);
        }
    }

    public void NPCTalk()
    {
        Debug.Log("I am an NPC");
        universalTalk.text = "Hello! I am a Test NPC!";
        uiTextAnimation.SetBool("IsTalking", true);

    }
}
