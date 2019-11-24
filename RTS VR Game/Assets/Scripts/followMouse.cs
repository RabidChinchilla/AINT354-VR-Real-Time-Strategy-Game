using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{

    public float distance = 30.0f;
    public bool useInitialCameraDistance = false;
    public GameObject commandPost;

    private float actualDistance;

    // Start is called before the first frame update
    void Start()
    {
        if (useInitialCameraDistance == true)
        {
            Vector3 toObjectVector = transform.position - Camera.main.transform.position;
            Vector3 linearDistanceVector = Vector3.Project(toObjectVector, Camera.main.transform.forward);
            actualDistance = (linearDistanceVector).magnitude;
        }
        else
        {
            actualDistance = distance;
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.y = commandPost.transform.position.y + 10;
        mousePosition.z = actualDistance;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
