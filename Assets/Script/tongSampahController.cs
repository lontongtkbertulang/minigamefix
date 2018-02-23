using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongSampahController : MonoBehaviour
{
    public float speed = 2f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GoLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            GoRight();
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
