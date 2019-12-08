using UnityEngine;

public class Billboard : MonoBehaviour {

    private Quaternion _rotateUpToForward = Quaternion.FromToRotation(Vector3.up, Vector3.forward);
    private static Transform _mainCameraTransform;

    // Use this for initialization
    void Start ()
    {
        _mainCameraTransform = Camera.main.transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.forward = _rotateUpToForward * -_mainCameraTransform.forward;
    }
}
