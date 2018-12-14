using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float speed;
    Vector3 lastPos;
    public static float CSpeed = 3.3f;
    public Rigidbody2D RbDorbin;
    //public float CSpeed=10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector2.left * Time.deltaTime * CSpeed * (Mathf.Sqrt(transform.position.x / 100) + 1));
        //RbDorbin.velocity = (this.transform.position - lastPos);
        //RbDorbin.velocity = new Vector2(CSpeed, 0f);
	}
}
