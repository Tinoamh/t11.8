using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    [SerializeField]private float speed;
    
    private Rigidbody2D body;
    private float t2;
    private float t1;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update(){
        body.velocity=new Vector2(Input.GetAxis("Horizontal")*speed,body.velocity.y);
        if(Input.GetKey(KeyCode.Space))
            body.velocity=new Vector2(body.velocity.x,speed);
    }
}
