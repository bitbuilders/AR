using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 20.0f)] float m_speed = 1.0f;

    Vector3 m_startPos;
    Camera m_camera;

    void Start()
    {
        m_startPos = transform.position;
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = m_camera.transform.position - transform.position;
        Vector3 velocity = dir.normalized * m_speed;

        transform.position += velocity;
    }
}
