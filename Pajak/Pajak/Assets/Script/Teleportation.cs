using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject teleport;
    public GameObject player;
    public GameObject buttonSign;

    public bool canTeleport;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && canTeleport)
        {
            StartCoroutine(Teleport());
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            canTeleport = true;
        }

        buttonSign.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            canTeleport = false;
        }

        buttonSign.SetActive(false);
    }
    public IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0.2f);
        player.transform.position = new Vector2(teleport.transform.position.x, teleport.transform.position.y);
        StopCoroutine(Teleport());
    }
}
