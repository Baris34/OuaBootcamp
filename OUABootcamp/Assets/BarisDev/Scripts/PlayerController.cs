using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private Rigidbody2D rb;
    private bool facingRight = true;
    [SerializeField] private Animator animator;
    private float horizontalInput;

    [SerializeField] private PlayerData _playerData;

    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackRange;
    [SerializeField] private LayerMask enemyLayer;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        attackAnimationController();
    }

    private void FixedUpdate()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput*speed*Time.deltaTime, rb.velocity.y);
        
        runAnimationController();
        if (horizontalInput<0&& facingRight)
        {
            flip(true);
        }else if (horizontalInput>0.01&&!facingRight)
        {
            flip(false);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Enemy")
        {
           
            if (other.gameObject.GetComponent<Enemy>().EnemyDamage>=_playerData.PlayerHealth)
            {
                _playerData.PlayerHealth = 0;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("takeDamage");
        _playerData.PlayerHealth -= damage;
        if (_playerData.PlayerHealth<=0)
        {
            animator.SetTrigger("Dead");
        }
    }
    
    
    private void flip(bool value)// karakterin baktığı yönü düzenlemek için yazılan bir metod.
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = value;
        facingRight = !facingRight;
    }

    private void runAnimationController()
    {
        if (horizontalInput!=0)
        {
            animator.SetBool("isRunning",true);
        }
        else
        {
            animator.SetBool("isRunning",false);
        }
    }

    private void attackAnimationController()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
            foreach (Collider2D enemy in hitEnemies)
            {
                BossScript bossHealth = enemy.GetComponent<BossScript>();
                EnemyScript enemyScript = enemy.GetComponent<EnemyScript>();
                if (bossHealth != null)
                {
                    bossHealth.takeDamage(_playerData.PlayerDamage);
                }
                else if (enemyScript!=null)
                {
                    enemyScript.takeDamage(_playerData.PlayerDamage);
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
