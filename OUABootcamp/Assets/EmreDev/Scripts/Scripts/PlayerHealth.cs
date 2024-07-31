using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthBase
{
    public static PlayerHealth instance;

    public override void Awake()
    {
        base.Awake();
        instance = this;
    }

    public override void Die()
    {
        gameObject.SetActive(false);
    }
}