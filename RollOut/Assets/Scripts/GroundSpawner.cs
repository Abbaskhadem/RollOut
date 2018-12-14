﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {
    //Object
    public GameObject SpawnerPoint;
    public GameObject Ground1;
    GameObject LastItem;
    //Vector
    Vector2 SpawnPos;
    Vector3 Rotation;
    //Variables
    int Count=0;
    float PosY;
    float RotZ;
    public float enemyDistances;


	void Start () {
        SpawnGround();
		
	}
	
	void Update () {
      
        if (enemyDistances > (this.transform.position.x - LastItem.transform.position.x))
            return;
            RotZ = Random.Range(-6f, 6f);
            PosY = Random.Range(-2.7f, -4.2f);
            SpawnGround();

        
	}
    public void SpawnGround()
    {




        LastItem = (GameObject)Instantiate(Ground1, SpawnerPoint.transform.position, Quaternion.Euler(new Vector3(0, 0, RotZ)));

    }
   
}
