using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector3 mousePosition;
    Vector2 movement;

    void Update()
    { // Update is called once per frame
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("mainMenu");
        }
    }

    void FixedUpdate()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        angle -= 90;
        transform.eulerAngles = new Vector3 (0, 0, angle);

        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed = 5f;

            transform.position += transform.up * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = 2.5f;

            transform.position += transform.right * Time.deltaTime * moveSpeed;
        } 

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeed = -2.5f;

            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = -4.5f;

            transform.position += transform.up * Time.deltaTime * moveSpeed;
        }
    }
}
