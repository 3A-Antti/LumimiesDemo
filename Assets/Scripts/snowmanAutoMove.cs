using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowmanAutoMove : MonoBehaviour
{
    float moveSpeed = 10f;
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
}
