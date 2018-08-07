using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject m_projectile = null;
    [SerializeField] [Range(0.0f, 100.0f)] float m_force = 10.0f;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Attack()
    {
        GameObject go = Instantiate(m_projectile);
        go.transform.position = transform.position;
        go.transform.rotation = transform.rotation;
        Vector3 dir = go.transform.forward;
        go.GetComponent<Rigidbody>().AddForce(dir * m_force, ForceMode.Impulse);
    }
}
