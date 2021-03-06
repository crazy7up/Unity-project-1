﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BasicStats {

    /* public string userClass;

     public float baseAttackPower;
     public float curAttackPower;

     public float baseAttackSpeed;
     public float curAttackSpeed;

     public float baseDodge;
     public float curDodge;

     public float baseHitPercent;
     public float curHitPercent;
     */

    [Header("-Player-")]
    [Space(10, order = 0)]

    [Tooltip("Player Name")]
    public string username; //Player Name

    [Tooltip("Player Level")]
    public int level; //Player Level

    [Tooltip("Current amount of Experience Points")]
    public float curXp;
    [Tooltip("Maximum amount of XP leading to Level Up")]
    public float maxXp;

    [Tooltip("Player Class")]
    public string userClass; //Player Class
    [Tooltip("If the player is currently dead")]
    public bool isDead;

    /*
     * base<var> = users raw stats (no items/buffs etc..)
     * cur<var> = users raw stats + item stats, buffs, etc..
     * 
    */

    //Player Lifeforce
    [Space(20, order = 0)]
    [Header("-Lifeforce-")]
    [Space(10, order = 0)]

    [Tooltip("Amout of HP currently available")]
    public float curHp; //HP
    [Tooltip("Maximum amount of HP")]
    public float maxHp;

    [Tooltip("Amout of Energy currently available")]
    public float curEnergy; //mana/energy
    [Tooltip("Maximum amount of Energy")]
    public float maxEnergy;

    [Tooltip("X sec until HP is regenerated")]
    public float hpRegenTimer;
    [Tooltip("Amount of HP regenerated")]
    public float hpRegenAmout;


    [Tooltip("X sec until Energy is regenerated")]
    public float energyRegenTimer;
    [Tooltip("Amount of Energy regenerated")]
    public float energyRegenAmount;

    //Player Attack
    [Space(20, order = 0)]
    [Header("-Player Attack-")]
    [Space(10, order = 0)]

    [Tooltip("Damage without equipment (or buffs)")]
    public float baseAttackPower; //Damange
    [Tooltip("Amount of damage the Player Deals")]
    public float curAttackPower;

    [Tooltip("Attack speed without equipment (or buffs)")]
    public float baseAttackSpeed; //Attack speed
    [Tooltip("How many times the Player Swings an Attack in a second")]
    public float curAttackSpeed;

    [Tooltip("Hit Percentage wihtout equipment (or buffs)")]
    public float baseHitPercent;
    [Tooltip("Increases the Players chance to land an attack")]
    public float curHitPercent;

    //Player Defense
    [Space(20, order = 0)]
    [Header("-Player Defense-")]
    [Space(10, order = 0)]

    [Tooltip("Player Armor without equipment (or buffs)")]
    public float baseArmor; //Armor
    [Tooltip("Amount of damage taken reduced")]
    public float curArmor;

    [Tooltip("Dodge Chance without equipment (or buffs)")]
    public float baseDodge;
    [Tooltip("Dodge increases the chance an enemy will miss an attack towards the player")]
    public float curDodge;

    [Space(20, order = 0)]
    [Header("-Utility-")]
    [Space(10, order = 0)]

    [Tooltip("Movement Speed without equipment (or buffs)")]
    public float baseMovementSpeed; //Movement Speed
    [Tooltip("How quickly the Player traverses the world")]
    public float curMovementSpeed;



    /*
     * THOUGHT
     * if no buffs exists for speccable stats, cur<var> not needed.
    */

    [Space(20, order = 0)]
    [Header("-Speccable Stats-")]
    [Space(10, order = 0)]

    public float baseStrength; //Strength
    [Tooltip("Strength Increases Damage")]
    public float curStrength;

    public float baseVitality;
    [Tooltip("Vitality Increases HP")]
    public float curVitality;

    public float baseDexterity;
    [Tooltip("Dexterity Increases Attack Speed")]
    public float curDexterity;
}
