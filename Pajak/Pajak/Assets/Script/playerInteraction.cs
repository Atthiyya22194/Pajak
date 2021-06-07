using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteraction : MonoBehaviour
{
    public GameObject baloonChat;
    public GameObject notification;

    void Start()
    {
        baloonChat.SetActive(false);
        notification.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        baloonChat.SetActive(true);
        notification.SetActive(false);
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        baloonChat.SetActive(false);
        notification.SetActive(true);
    }
}
