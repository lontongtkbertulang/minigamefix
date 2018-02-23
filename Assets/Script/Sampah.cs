using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampah : MonoBehaviour
{
    private Scores myScore;
    int scorePlus = 10;

    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        myScore = other.gameObject.GetComponent<Scores>();
        Destroy(gameObject);
        //myScore.AddScore(scorePlus);
        Scores.score += 10;
    }
}
