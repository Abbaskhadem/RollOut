using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {
    //Object
    public GameObject SpawnerPoint;
    GameObject LastItem;
    public GameObject SpawnerTrap;
    public GameObject[] Ground;
    public GameObject[] Traps;
    GameObject temp;
    GameObject Tree;
    GameObject currentTree;
    //Vector
    Vector2 TreePos;
    Vector2 currentTreePos;
    Vector2 SwampPos;
    Vector2 currentSwampPos;
    Vector2 SpawnPos;
    Vector3 Rotation;
    //Variables
    int Count=0;
    int Temp = 0;
    int rand;
    float PosY;
    float RotZ;
    float a, b;
    
    public float enemyDistances;


	void Start () {
            SpawnGround();
	}
	
	void Update () {
        if (GameManager.LoseGame == true || GameManager.Go==false || GameManager.GameStarted==false)
            return;
        if (enemyDistances > (this.transform.position.x - LastItem.transform.position.x))
            return;
            RotZ = Random.Range(-1f, 2f);
            PosY = Random.Range(-5.13f,-6f ); 
            SpawnGround();
               SpawnTraps();  
	}
    public void SpawnGround()
    {
        rand = Random.Range(0, 4);
       LastItem = (GameObject)Instantiate(Ground[rand], SpawnerPoint.transform.position, Quaternion.Euler(new Vector3(0, 0, RotZ)));
    }
    public void SpawnTraps()
    {
        Temp = Random.Range(0, 2);
        if (Temp == 1)
        {
            Debug.Log("4");
        currentTree = Instantiate(Traps[Temp], SpawnerTrap.transform.position, Quaternion.identity);
       
            Debug.Log("1");
            



            currentTreePos = currentTree.transform.position;
            
            
            Debug.Log("2");
            //Tree =(GameObject)Instantiate(Traps[Temp], currentSwampPos, Quaternion.identity);
        
            Debug.Log("raft tosh");
            TreePos = currentTree.transform.position;
            a = TreePos.x - 1.60f;
            b = TreePos.y - 0.88f;
            SwampPos = new Vector2(a, b);
            // TreePos = new Vector2(transform.position.x, transform.position.y);
            Debug.Log("3");
            Instantiate(Traps[2], SwampPos, Quaternion.identity);

        }
        else
        {
            Debug.Log("4");
            Instantiate(Traps[Temp], SpawnerTrap.transform.position, Quaternion.identity);
        }
    }
}
