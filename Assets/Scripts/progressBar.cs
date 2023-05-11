using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progressBar : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxProgress(int maxProgress)
    {
        slider.maxValue = maxProgress;
    }

    public void setProgress(int progress)
    {
        slider.value = progress;
    }
}
