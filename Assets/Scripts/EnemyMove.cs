﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int MoveTrigger;

    void Update()
    {
        if (MoveTrigger == 1)
        {
            EnemySpeed = 0.04f;
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }
    }
}
