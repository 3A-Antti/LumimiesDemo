using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeOverlay : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        target.transform.position = new Vector3(0, 0, 0);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        target.transform.position = new Vector3(0, -600, 0);
    }
}
