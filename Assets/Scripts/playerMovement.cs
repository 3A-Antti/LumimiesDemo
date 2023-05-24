using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed  = 5f;
    public float freezeTime = 5.0f;

    public Rigidbody2D rb;
    public Transform target;

    int destroyedObjects = 0;
    bool frozen = false;

    Vector3 mousePosition;
    Vector2 movement;

    void Update()
    { // Update is called once per frame
        if (Input.GetKey(KeyCode.Escape))
        {
            exitGame();
        }
    }

    void FixedUpdate()
    {
        if (!frozen)
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

    private void OnTriggerEnter2D() 
    {
        
    }

    public void exitGame()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void destroyCounter()
    {
        destroyedObjects += 1;

        if (destroyedObjects >= 3)
        {
            exitGame();
        }
    }

    public void freezePlayer()
    {
        frozen = true;
        freezeTime -= Time.deltaTime;
 
        target.transform.position = new Vector3(400f, 300f, 0f);

        if (freezeTime <= 0.0f)
        {
            print("lolol");
        }
    }
}
