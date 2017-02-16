﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerUI : MonoBehaviour {

    public float maxHp = 100;
    public float currentHp;
    public Slider hpSlider;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void TakeDamage (int amount)
    {
        currentHp -= amount;
        if(currentHp < 0)
        {
            currentHp = 0;
        }

        hpSlider.value = currentHp;
    }
}