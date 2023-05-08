using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;

public class sceneManager : MonoBehaviour
{
    public void Click()
    {
        if(EventSystem.current.currentSelectedGameObject.name == "lumimies")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("SampleScene");
        }

        if(EventSystem.current.currentSelectedGameObject.name == "tonttu")
        {
            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
            SceneManager.LoadScene("tontunNäkö");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
