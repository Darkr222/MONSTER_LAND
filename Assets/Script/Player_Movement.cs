using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float horizontalInput;
    public float _speed = 6;
    public Animator animator;
    void Start()
    {
        animator.GetComponent<Animator>();
    }

    
    void Update()
    {
        walk();
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
}
