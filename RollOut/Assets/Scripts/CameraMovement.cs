using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public static float CSpeed = 3.3f;
    public Rigidbody2D RbDorbin;
    //public float CSpeed=10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       RbDorbin.velocity = new Vector2(CSpeed, 0f);
	}
}
