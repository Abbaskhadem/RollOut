using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float RotationSpeed = -3f;
	
	// Update is called once per frame
	void Update () {
        if(GameManager.LoseGame==false)
        {
            transform.Rotate(0, 0, RotationSpeed);
        }
	}
}
