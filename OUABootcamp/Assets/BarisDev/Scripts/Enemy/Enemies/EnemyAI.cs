using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float followRange = 10f;
    public float attackRange = 2f;
    public float attackInterval = 2f;
    public float moveSpeed = 2f;

    private Animator animator;
    private float nextAttackTime = 0;
    private bool isFacingRight = true;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < followRange)
        {
            FollowPlayer(distanceToPlayer);
        }
        else
        {
            StopFollowingPlayer();
        }
    }

    void FollowPlayer(float distanceToPlayer)
    {
        if (distanceToPlayer > attackRange)
        {
           
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            animator.SetBool("isMoving", true);
            if (direction.x > 0 && isFacingRight)
            {
                Flip();
            }
            else if (direction.x < 0 && !isFacingRight)
            {
                Flip();
            }
        }
        else
        {

            animator.SetBool("isMoving", false);
            
            if (Time.time >= nextAttackTime)
            {
                animator.SetTrigger("isAttack");
                nextAttackTime = Time.time + attackInterval;
            }
        }
    }

    void StopFollowingPlayer()
    {
        animator.SetBool("isMoving", false);
    }

    void OnDrawGizmosSelected()
    {
        if (player == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, followRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
