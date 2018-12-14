using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {
    Vector3 _cameraLastPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2( (_cameraLastPos - Camera.main.transform.position).x / 30, 0);
        _cameraLastPos = Camera.main.transform.position;
        GetComponent<Renderer>().material.mainTextureOffset = GetComponent<Renderer>().material.mainTextureOffset - offset;
	}
}
