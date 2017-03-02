﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour
{
    public Transform drop;
    public Transform pos;
    enemyUI sRef;
    Animator anim;
    Transform goRef;
    enemyMovement enemy;

    // Use this for initialization
    void Start()
    {
        //reference to spider object with the script enemyUI on itself
        sRef = GameObject.FindGameObjectWithTag("Enemy").GetComponent<enemyUI>();
        anim = GetComponent<Animator>();
        enemy = GetComponent<enemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sRef.currentHp <= 0) //if currentHp <= 0
        {
            StartCoroutine(DestroyObj());
            anim.Play("Dead");
        }
    }
    IEnumerator DestroyObj()
    {
        enemy.enemyState = enemyStates.DEAD;
        yield return new WaitForSeconds(2);
        DropItem();
        Destroy(gameObject);
        yield break;
    }
    void DropItem()
    {
        if (Random.value <= 1) //%30 percent chance to happen (1 = 100%)
        {
            goRef = Instantiate(drop, gameObject.transform.position, gameObject.transform.rotation); //creates object on a position (choose in the editor!)
            goRef.name = drop.name;
        }
    }
}