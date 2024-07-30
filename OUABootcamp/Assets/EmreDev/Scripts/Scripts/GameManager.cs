using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemyData[] _enemyDatas;
    
    public EnemyData getEnemyData(string enemyName)
    {
        foreach (EnemyData enemyData in _enemyDatas)
        {
            if (enemyData.name==enemyName)
            {
                return enemyData;
            }
        }
        return null;
    }
}
