using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchItem : MonoBehaviour
{
    playerMovement PlayerMovement;

    public int completionProgress = 80;
    public int currentProgress;

    bool searching = false;
    bool sD0 = false;
    bool sD1 = false;
    bool sD2 = false;
    bool sD3 = false;
    bool sD4 = false;
    bool sD5 = false;
    bool sD6 = false;
    bool sD7 = false;
    bool sD8 = false;
    int destroyCount = 0;

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

        if (sD0)
        {
            PlayerMovement.exitGame();
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
                Abomination();

                Destroy(this.gameObject);
            }
        }
    }

    void Abomination()
    {
        if (!sD0)
        {
            sD0 = true;
        }

        /*if (sD0)
        {
            if (sD1)
            {
                if (sD2)
                {
                    if (sD3)
                    {
                        if (sD4)
                        {
                            if (sD5)
                            {
                                if (sD6)
                                {
                                    if (sD7)
                                    {
                                        sD8 = sD7;
                                    }

                                    sD7 = sD6;
                                }

                                sD6 = sD5;
                            }

                            sD5 = sD4;
                        }

                        print("sD4 = " + sD4);
                        sD4 = sD3;
                        print("sD4 = " + sD4);
                    }

                    sD3 = sD2;
                }

                sD2 = sD1;
            }

            print("sD1 = " + sD1);
            sD1 = sD0;
            print("sD1 = " + sD1);
        }*/
    }
}