using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchItem : MonoBehaviour
{
    playerMovement PlayerMovement;

    public int completionProgress = 80;
    public int currentProgress;

    bool searching = false;

    public progressBar progressBar;
    public Transform target;

    void Start()
    { // Start is called before the first frame update
        PlayerMovement = GameObject.Find("PLAYER").GetComponent<playerMovement>();
        
        currentProgress = 0;
        progressBar.SetMaxProgress(completionProgress);
    }

    void FixedUpdate()
    { // Update is called once per frame
        if (searching)
        {
            addProgress(5, searching);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target.transform.position = new Vector3(400f, 100f, 0);

            searching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target.transform.position = new Vector3(0f, -600f, 0f);

            currentProgress = 0;
            searching = false;
        }
    }

    void addProgress(int giveProgress, bool check)
    {
        if (check)
        {
            currentProgress += giveProgress;

            progressBar.setProgress(currentProgress);

            if (currentProgress == 640)
            {
                PlayerMovement.destroyCounter();

                Destroy(this.gameObject);
            }
        }
    }
}