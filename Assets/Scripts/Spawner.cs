using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject m_enemy = null;
    [SerializeField] [Range(0.0f, 60.0f)] float m_spawnRate = 1.5f;
    [SerializeField] [Range(0.0f, 10.0f)] float m_max;
    [SerializeField] [Range(0.0f, -10.0f)] float m_min;

    Camera m_camera;
    float m_time = 0.0f;
    
    void Start()
    {
        m_camera = Camera.main;
    }
    
    void Update()
    {
        m_time += Time.deltaTime;

        if (m_time >= m_spawnRate)
        {
            m_time = 0.0f;
            Vector3 rand = new Vector3(Random.Range(m_min, m_max), 0.0f, Random.Range(m_min, m_max));
            Vector3 pos = rand;
            pos += m_camera.transform.position;
            pos.y = 0.0f;
            Instantiate(m_enemy, pos, Quaternion.identity, transform);
        }
    }
}
