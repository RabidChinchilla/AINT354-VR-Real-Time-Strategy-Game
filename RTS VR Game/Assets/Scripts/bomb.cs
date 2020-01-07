using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Explosion");
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
