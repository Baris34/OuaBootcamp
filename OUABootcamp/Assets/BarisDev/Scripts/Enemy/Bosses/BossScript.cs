using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private Animator anim;
    public EnemyData boss;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void takeDamage(int damage)
    {
        anim.SetTrigger("isHurt");
        boss.EnemyHealth -= damage;
        if (boss.EnemyHealth<=0)
        {
            anim.SetTrigger("isDead");
        }
    }
}
