using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowmanAutoMove : MonoBehaviour
{
    public Transform target;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("ddd");
            target.transform.position = new Vector3(400f, 300f, 0f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("aaa");
            target.transform.position = new Vector3(0f, -600f, 0f);
        }
    }
}
