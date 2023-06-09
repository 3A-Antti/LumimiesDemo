using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour
{
    playerMovement PlayerMovement;

    float moveSpeed = 5f;
    float rotSpeed  = 0.75f;

    bool freezeCheck = false;

    void Start()
    {
        PlayerMovement = GameObject.Find("PLAYER").GetComponent<playerMovement>();

        transform.Rotate(0, 0, -90f);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, rotSpeed);
        transform.position += transform.up * Time.deltaTime * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!freezeCheck)
        {
            moveSpeed = 0f;
            rotSpeed  = 0f;
        
            freezeCheck = true;

            PlayerMovement.destroyCounter();
        }
    }
}
