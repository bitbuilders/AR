using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.zero;
        velocity.y = Mathf.PingPong(Time.time * 0.5f, 0.5f);

        transform.position = velocity;
    }
}
