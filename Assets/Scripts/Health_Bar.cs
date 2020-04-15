﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{

    public Slider slider;
    public Text NumericalHealth;

    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;
        
    }

    public void SetHealth(int health) {
        slider.value = health;
    }

 }
