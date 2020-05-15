﻿ using System.Collections;
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

    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
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
            //GetComponent<SpriteRenderer>().flipX
        }
    }
    void StopChasingPlayer() {
        rb2d.velocity = new Vector2(0, 0);
    }
}
