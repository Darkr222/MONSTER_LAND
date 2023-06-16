using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float horizontalInput;
    public float _speed = 10;
    void Start()
    {
        
    }

    
    void Update()
    {
        walk();
    }

    private void walk()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(horizontalInput, 0f, 0f) * _speed * Time.deltaTime;


    }
}
