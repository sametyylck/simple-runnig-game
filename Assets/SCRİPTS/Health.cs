using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

    public void Maxcan(int healt)
    {
        slider.maxValue=healt;
        slider.value=healt;
    }
    public void Sethealt(int healt)
    {
        slider.value=healt;
    }
}
