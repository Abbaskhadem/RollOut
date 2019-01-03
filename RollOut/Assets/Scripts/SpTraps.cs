using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpTraps : MonoBehaviour {
    public GameObject[] Traps;
    GameObject LastItem;
    public int Temp;
    float nextspawn = 0.0f;
    public GameObject SpawnerPoint;
    Vector2 whereTospawn;
    float roundX;
    public float Timer;
    public float Timer01;
    // Use this for initialization
    void Start () { 
        SpawnGround();
    }
	
	// Update is called once per frame
	void Update () {
        Timer01 = Random.Range(6f, 15f);
        Timer = Time.deltaTime + Timer;
        if (Timer>=Timer01)
        {
            Timer = 0;
            SpawnGround();
        }
    }
    public void SpawnGround()
    {
        Temp = Random.Range(0, Traps.Length);
        LastItem = (GameObject)Instantiate(Traps[Temp], SpawnerPoint.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
    }
}
