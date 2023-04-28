using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotSpeed  = 0.75f;

    void Start()
    {
        transform.Rotate(0, 0, -90f);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, rotSpeed);
        transform.position += transform.up * Time.deltaTime * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        moveSpeed = 0f;
        rotSpeed  = 0f;
    }
}