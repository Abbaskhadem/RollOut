﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpTraps : MonoBehaviour {
    public GameObject Tr1;
    public GameObject Tr2;
    float nextspawn = 0.0f;
    public GameObject SpawnerPoint;
    Vector2 whereTospawn;
    float roundX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextspawn)
        {

            roundX = Random.Range(-1.66f, 2);
            whereTospawn = new Vector2(roundX, transform.position.y);
            Instantiate(Tr1, SpawnerPoint.transform.position, Quaternion.identity);
        }
	}
}
