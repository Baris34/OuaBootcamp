using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform bitePoint;
    public float biteRange = 0.5f;
    public LayerMask playerLayer;
    private Enemy _enemy;


    private void Awake()
    { 
        _enemy = GetComponent<Enemy>();
    }
    public void BiteHit()
    {
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(bitePoint.position, biteRange, playerLayer);
        foreach (Collider2D player in hitPlayers)
        {
            player.GetComponent<PlayerController>().TakeDamage(_enemy.EnemyDamage);
        }
    }
    public void FishAttack()
    {
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(bitePoint.position, biteRange, playerLayer);
        foreach (Collider2D player in hitPlayers)
        {
            player.GetComponent<PlayerController>().TakeDamage(_enemy.EnemyDamage);
        }
        Destroy(gameObject);
    }
    void OnDrawGizmosSelected()
    {
        if (bitePoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(bitePoint.position, biteRange);
    }
}
