using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private int enemyDamage;
    [SerializeField] private int enemyHealth;

    private void Start()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        EnemyData enemyData = gameManager.getEnemyData(enemyName);

        if (enemyData!=null)
        {
            enemyHealth = enemyData.EnemyHealth;
            enemyDamage = enemyData.EnemyDamage;
        }
    }

    public int EnemyDamage
    {
        get => enemyDamage;
        set => enemyDamage = value;
    }

    public int EnemyHealth
    {
        get => enemyHealth;
        set => enemyHealth = value;
    }
}
