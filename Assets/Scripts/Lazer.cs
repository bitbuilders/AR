using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

    [SerializeField] GameObject m_lazerHit1 = null;
    [SerializeField] GameObject m_lazerHit2 = null;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    }


    private void OnParticleTrigger()
    {
        //print("hi");
    }

    private void OnParticleCollision(GameObject other)
    {
        Vector3 dir = transform.position - other.transform.position;
        if (other.GetComponent<MeshCollider>() != null)
        {
            m_lazerHit1.transform.position = other.transform.position;
            m_lazerHit1.transform.rotation = other.transform.rotation;
        }
        else
        {
            other.GetComponent<Enemy>().Health = other.GetComponent<Enemy>().Health - 8.0f;
            m_lazerHit2.transform.position = other.transform.position;
            m_lazerHit2.transform.rotation = Quaternion.Euler(-90.0f, 0.0f, 0.0f);
            m_lazerHit2.transform.rotation = other.transform.rotation * m_lazerHit2.transform.rotation;
        }
    }
}
