using UnityEngine;

[CreateAssetMenu(menuName = "DataHolders/Structure Properties")]
public class StructureProperties : UnitProperties {

    // Basic params
    public bool isUsingEnergy;
    public int damage;
    public int energy;
    [Space(10)]
    [Header("Mining")]  
    public bool canMine;
    public float miningInterval;
    [Space(10)]
    [Header("Attacking")]
    public bool canShoot;
    public float reloadTime;
    public float rotationSpeed;
    public float firingRange;

}
