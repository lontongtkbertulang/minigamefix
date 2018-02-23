using UnityEngine;
using System.Collections;

public class SpawnTrash : MonoBehaviour
{

    public Transform trashDrop;
    public int numToSpawn;
    public Vector3 position;


    void Start()
    {
        int spawned = 0;

        while (spawned < numToSpawn)
        {
            position = new Vector3(Random.Range(10.0F, -10.0F), 70, 0);
            Instantiate(trashDrop, position, Quaternion.identity);
            spawned++;
        }
    }

}