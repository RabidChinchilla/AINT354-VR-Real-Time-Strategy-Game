using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Camera
    public int MaxHeight = 100;
    public int MinHeight = 30;
    public float MovementMargin = 0.1f; // percentage of screen
    public float ZoomStep = 20;
    public float MovementSpeed = 2.5f;

    private int _maxAllowedMovement;
    private Vector2 _screenSize;

    public bool IsStopped
    {
        get { return _isStopped; }
        set { _isStopped = value; }
    }
    private bool _isStopped = false;

    void Start()
    {
        // Should calculate maximum camera movement distance based on camera FOV and maximum height
        _maxAllowedMovement = Constants.TERRAIN_HALF_SIZE;// -cameraMovementMargin;
        _screenSize.x = Screen.width;
        _screenSize.y = Screen.height;
    }

	// Update is called once per frame
	void Update () {
        // Press space to block camera movement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isStopped = !_isStopped;
        }

        if (_isStopped)
            return;

        Vector3 mousePos = Input.mousePosition;

        Vector3 cameraPos = transform.position + Camera.main.transform.forward * Input.GetAxis("Mouse ScrollWheel") * ZoomStep;
        // Zoom camera along its forward axis
        if (cameraPos.y > MaxHeight || cameraPos.y < MinHeight)
            cameraPos = transform.position;
        if (mousePos.x < _screenSize.x * MovementMargin && mousePos.x > 0)
        {
            cameraPos -= Vector3.right * MovementSpeed * (1 - mousePos.x/(_screenSize.x * MovementMargin));
        }
        if (mousePos.x > Screen.width - _screenSize.x * MovementMargin && mousePos.x < Screen.width)
        {
            cameraPos += Vector3.right * MovementSpeed * (1-(Screen.width - mousePos.x) / (_screenSize.x * MovementMargin));
        }
        if (mousePos.y < _screenSize.y * MovementMargin && mousePos.y > 0)
        {
            cameraPos -= Vector3.forward *  MovementSpeed * (1-mousePos.y / (_screenSize.y * MovementMargin));
        }
        if (mousePos.y > Screen.height - _screenSize.y * MovementMargin && mousePos.y < Screen.height)
        {
            cameraPos += Vector3.forward * MovementSpeed * (1-(Screen.height - mousePos.y) / (_screenSize.y * MovementMargin));
        }

        // Check terrain boundaries
        Mathf.Clamp(cameraPos.x, -_maxAllowedMovement, _maxAllowedMovement);
        Mathf.Clamp(cameraPos.z, -_maxAllowedMovement, _maxAllowedMovement);
        transform.position = cameraPos;
    }

}
