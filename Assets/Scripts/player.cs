using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    
    
    private Animator _animator;
    private bool _isTouchingGround;
    private bool facingRight = true;
    private Rigidbody2D _rigidbody2D;

    public Health_Bar healthbar;
    
    public int maxHealth = 20;
    public int currentHealth;

    public Text NumericalHealth;
    //[SerializeField] TextMeshProGUI NumericalHealth;


    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
         

        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

        NumericalHealth.text = maxHealth.ToString();

        





    }

    // Update is called once per frame
    private void Update()
    {

        Debug.Log(currentHealth.ToString());
        NumericalHealth.text = currentHealth.ToString();

        if (Input.GetKeyDown(KeyCode.S)) {
            TakeDamage(1);
            NumericalHealth.text = currentHealth.ToString();
            Debug.Log(currentHealth);
        }
        
        float move = Input.GetAxis("Horizontal");
        Jump();
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("idle", false);
            _animator.SetBool("run", true);
            _rigidbody2D.velocity = new Vector2(speed * move, _rigidbody2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("idle", false);
            _animator.SetBool("run", true);
            _rigidbody2D.velocity = new Vector2(speed * move, _rigidbody2D.velocity.y);
            
        }
        else
        {
            StopVelocityOnPlayer();
            _animator.SetBool("run", false);
            _animator.SetBool("idle", true);
        }

        if (Input.GetKeyDown(KeyCode.D) && !facingRight)
        {
            Flip();
            
        }
        else if(Input.GetKeyDown(KeyCode.A) && facingRight)
        {
            Flip();
        }


        //if (transform.position.x < -6.30)
        //{
        //    transform.position = new Vector2(-6.30f, transform.position.y);
        //}
    }

    private void StopVelocityOnPlayer()
    {
        Vector3 tempVelocity = _rigidbody2D.velocity;
        tempVelocity.x = 0.0f;
        _rigidbody2D.velocity = tempVelocity;
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 tempScale = transform.localScale;
        tempScale.x *= -1;
        transform.localScale = tempScale;
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.W) && !_isTouchingGround)
        {
            _isTouchingGround = true;
            _rigidbody2D.AddForce(new Vector2(_rigidbody2D.velocity.x, jumpForce));
            StopVelocityOnPlayer();
            _animator.SetBool("run", false);
            _animator.SetBool("idle", false);
            _animator.SetBool("jump", true);
        }
        else {
            _animator.SetBool("jump", false);
        }
        

    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            Debug.Log("ground");
            _isTouchingGround = false;
            _rigidbody2D.velocity = Vector2.zero;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("hello world!");
        if (other.gameObject.tag == "bg")
        {
            Debug.Log("hello world!");
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        NumericalHealth.text = currentHealth.ToString();

    }


}
