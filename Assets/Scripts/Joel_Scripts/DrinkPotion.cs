﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class DrinkPotion : MonoBehaviour {

    public Inventory inventory;
    public ActionBar aB;

    public AudioClip Blub_Potion_Sound;
    AudioSource audioNew;

    void Start()
    {
        audioNew = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var Player = this.GetComponent<UserStats>();

            if (inventory.ItemExist("Health Potion"))
            {
                inventory.RemoveItem("Health Potion");
                //.RemoveItem("Health Potion");
                Player.curHp += Player.maxHp/2;
                audioNew.PlayOneShot(Blub_Potion_Sound, 0.7F);
                if(Player.curHp > Player.maxHp)
                {
                    Player.curHp = Player.maxHp;
                }
            }
        }
    }
}
