using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    Animator Button;
    public GameObject Platform;

    void Start()
    {
        Button = GetComponent<Animator>();
        Platform.gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Platform.gameObject.SetActive(false);
        Button.SetInteger("Button", 1);
    }
}
