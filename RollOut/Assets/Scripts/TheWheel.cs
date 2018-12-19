using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWheel : MonoBehaviour
{
    public static float Speed =5;
    public Rigidbody2D RbCharkh;
    Vector3 lastPos;
    
    void Update()
    {


        // transform.Translate(Vector2.right * Speed * (Mathf.Sqrt(transform.position.x / 100) + 1));
        // 
        
       // RbCharkh.velocity = new Vector2(Speed, 0f);

        if (Time.deltaTime < Speed)
        {
            Speed += (Time.deltaTime);
            

        }

        RbCharkh.velocity = new Vector2(Speed, 0f);
        //Speed += Time.deltaTime;
        // transform.Translate(Speed, 0, 0);
    }
}

