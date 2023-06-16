using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float horizontalInput;
    public float _speed = 6;
    public Animator animator;
    public Rigidbody2D rBody;
    public bool _isGrounded;
    public float jumpAmount = 15;

    void Start()
    {
        animator.GetComponent<Animator>();
    }

    
    void Update()
    {
        walk();
        playerjump();
    }

    private void walk()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput, 0f, 0f) * _speed * Time.deltaTime;
        animator.SetFloat("_speed", Mathf.Abs(horizontalInput)); // player horizontal movement and walk animation

        Vector3 playerScale = transform.localScale;
        if(Input.GetAxis("Horizontal") > 0 )
        {
            playerScale.x = 1;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerScale.x = -1;
        }

        transform.localScale = playerScale; // player filp
    }

    private void playerjump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            rBody.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetTrigger("jump", 
            _isGrounded = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground")) ;
        {
            _isGrounded = true;
        }
    }
}
