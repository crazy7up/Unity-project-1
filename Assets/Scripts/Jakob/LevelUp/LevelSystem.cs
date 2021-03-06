﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public UserStats stats;

    Rect rect = new Rect(32, 600, 200, 50);

    string lvText = "Lv:";

    public GUIStyle guiLevel;

    public GameObject particleEffectLevel;  //Get gameobject with a particle system in it: in this case the Level Up particle effect
    StartParticleTest sn;                   //sn = scriptName

    public GameObject UITextHandler;
    UITextHandler lvlUpTxt;

    AudioClipsYo lvlSound;

    // Use this for initialization
    void Start ()
    {
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<UserStats>();
        sn = particleEffectLevel.GetComponent<StartParticleTest>();                         //Set sn to a gameobjects script<StartParticleTest>
        lvlSound = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioClipsYo>(); //Set lvlSound to playerGameObjects script<
        lvlUpTxt = GameObject.FindObjectOfType<UITextHandler>() as UITextHandler;

    }
	
	// Update is called once per frame
	void Update ()
    {
        LevelUp();
	}

    void LevelUp()
    {
        if (stats.curXp >= ((stats.level + 100) * stats.level + 13))
        {
            sn.PlayPartEff(); //Plays Particvle Effect for Leveling Up

            lvlSound.playLevelUp(); //Plays Sound Effect for Leveling Up
            StartCoroutine(lvlUpTxt.textShowLevelUp()); //Show Text on Screen When Leveling Up
            float tempXp = stats.curXp;
            stats.curXp = tempXp - ((stats.level + 100) * stats.level + 13);
            stats.level++;
            stats.statPoints += 5;
            stats.curHp = stats.maxHp;
        }
    }
}
