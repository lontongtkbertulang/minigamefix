using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Trash_Can_Controller : MonoBehaviour
{

    public float speed = 1.0f;

    public Text textScore;
    public Text WinText;
    private int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        SetTextScore();
        WinText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //objek ke kiri
            GoLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            //objek ke kanan
            GoRight();
        }
        SetTextScore();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sampah"))
        {
            other.gameObject.SetActive(true);
            score = score + 1;
            Debug.Log("Score Bertambah");
            SetTextScore();
        }
    }

    void SetTextScore()
    {
        textScore.text = score.ToString();
        if (score >= 10)
        {
            WinText.text = "You Win!";
        }
    }

    private void GoLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void GoRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

}
