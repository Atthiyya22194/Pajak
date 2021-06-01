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

    void OnCollisionEnter2D(Collision2D coll)
    {
        baloonChat.SetActive(true);
        notification.SetActive(false);
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        baloonChat.SetActive(false);
        notification.SetActive(true);
    }
}
