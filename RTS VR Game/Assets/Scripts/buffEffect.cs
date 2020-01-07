using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffEffect : MonoBehaviour
{

    public GameObject effect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Debug.Log("buff effect");
            Destroy(gameObject);
        }
    }
}
