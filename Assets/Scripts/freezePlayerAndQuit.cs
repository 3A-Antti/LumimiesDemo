using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezePlayerAndQuit : MonoBehaviour
{
    playerMovement PlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("PLAYER").GetComponent<playerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerMovement.freezePlayer();
        }
    }
}
