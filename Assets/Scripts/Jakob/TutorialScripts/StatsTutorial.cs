﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsTutorial : MonoBehaviour
{

    public GameObject childText;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Paladin")
        {
            childText.SetActive(true);
            Destroy(gameObject);
        }

    }
}