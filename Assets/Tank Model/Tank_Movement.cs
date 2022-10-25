using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 50.0f;
    public float turnSpeed = 500.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime;
        float steering = Input.GetAxis("Horizontal");
        float turn = steering * turnSpeed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate(0.0f, 0.0f, movement);
        t.Rotate(0.0f, turn, 0.0f);
    }
}
