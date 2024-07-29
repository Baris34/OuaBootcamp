using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameData",menuName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Stats")] 
    [SerializeField] private string enemyName;
    [SerializeField] private int enemyDamage;
    [SerializeField] private int enemyHealth;

    public string EnemyName
    {
        get => enemyName;
        set => enemyName = value;
    }

    public int EnemyDamage
    {
        get => enemyDamage;
        set => enemyDamage = value;
    }

    public int EnemyHealth
    {
        get => enemyHealth;
        set
        {
            if (enemyHealth<=0)
            {
                enemyHealth = 0;
            }
            else
            {
                enemyHealth = value;
            }
        }
    }
}
