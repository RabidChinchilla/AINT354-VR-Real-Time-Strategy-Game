using UnityEngine;

/// <summary>
/// Reads a superset of properties from file, shared by moving vehicles, and 
/// makes them available to other components such as the VehicleController.
/// </summary>
[CreateAssetMenu(menuName = "DataHolders/Vehicle Properties")]
public class VehicleProperties : UnitProperties {

    // Basic params
    public float speed;
    public float rotationSpeed;
    [Space(10)]
    [Header("Mining")]
    public bool canMine;
    public float miningInterval;
    [Space(10)]
    [Header("Attacking")]
    public bool canShoot;
    public float firingRange;
    public float reloadTime;

}
