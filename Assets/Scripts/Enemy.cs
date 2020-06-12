 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    public int enemy_max_health = 20;
    public int enemy_current_health;
    public float invulTime = 3f;
    public bool invulnerable = false;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        enemy_current_health = enemy_max_health;
    }
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);


        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }


        if (distToPlayer < 0.7) {
            StopChasingPlayer();
        }

        
    }





    void ChasePlayer() {

        if (transform.position.x < player.position.x) {
            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(5, 5);
        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-5, 5);
            //GetComponedint<SpriteRenderer>().flipX
        }
    }
    void StopChasingPlayer() {
        rb2d.velocity = new Vector2(0, 0);
    }
    public void EnemyTakeDamage(int damage)
    {
        if (!invulnerable)
        {
            enemy_current_health -= damage;

         
        }


    }


    IEnumerator JustHurt()
    {
        invulnerable = true;
        yield return new WaitForSeconds(invulTime);
        invulnerable = false;
    }


}
