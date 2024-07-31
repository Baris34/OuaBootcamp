using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameData",menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    [Header("Player Stats")]
    [SerializeField] private int playerHealth;
    [SerializeField] private int playerDamage;
    [SerializeField] private int playerMaxHealth;

    public int PlayerHealth
    {
        get => playerHealth;
        set
        {
            if (playerHealth<=0)
            {
                playerHealth = 0;
            }
            else
            {
                playerHealth = value;
            }
        }
    }

    public int PlayerDamage
    {
        get => playerDamage;
        set => playerDamage = value;
    }
}
