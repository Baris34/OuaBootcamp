using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Animator anim;
    public EnemyData enemy;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void takeDamage(int damage)
    {
        anim.SetTrigger("isDamaged");
        enemy.EnemyHealth -= damage;
        if (enemy.EnemyHealth<=0)
        {
            anim.SetTrigger("isDead");
        }
    }
}
