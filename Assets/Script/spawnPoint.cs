using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {

    public Transform[] SpawnPoints;
    public float spawnTime = 1.5f;

    public GameObject Trash;
    //public GameObject Trash;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnTrash", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnTrash()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);//set the index number of the array randomly
        Instantiate(Trash, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
}
