using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 20.0f)] float m_speed = 1.0f;
    [SerializeField] [Range(0.0f, 1000.0f)] float m_healthGrow = 100.0f;
    [SerializeField] Color m_endColor;
    public float Health { get; set; }

    Vector3 m_startPos;
    Camera m_camera;
    Material m_material;
    [SerializeField] Color m_startColor;

    void Start()
    {
        m_startPos = transform.position;
        m_camera = Camera.main;
        Health = 1000.0f;
        m_material = GetComponentInChildren<Renderer>().material;
        m_startColor = m_material.GetColor("_BaseColorFactor");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dir = m_camera.transform.position - transform.position;
        //Vector3 velocity = dir.normalized * m_speed;

        //transform.position += velocity;

        float a = Health / 1000.0f;
        m_material.SetColor("_BaseColorFactor", Color.Lerp(m_endColor, m_startColor, a));
        Health += m_healthGrow * Time.deltaTime;
        Health = Mathf.Clamp(Health, 0.0f, 1000.0f);
    }

    private void OnApplicationQuit()
    {
        m_material.SetColor("_BaseColorFactor", m_startColor);
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
