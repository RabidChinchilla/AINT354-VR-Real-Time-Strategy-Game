using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds references to various prefabs and items which are widely used.
/// </summary>
public class ObjectFactory : Singleton<ObjectFactory>
{
    public GameObject Explosion;
    public GameObject Projectile;
    public GameObject[] UnitPrefabs;

    private Dictionary<string, GameObject> _unitPrefabNames;

    public GameObject GetUnitByName(string unitName)
    {
        if (_unitPrefabNames == null)
        {
            _unitPrefabNames = new Dictionary<string, GameObject>();
            foreach (GameObject unitPrefab in UnitPrefabs)
                _unitPrefabNames.Add(unitPrefab.GetComponent<UnitController>().UnitProperties.name, unitPrefab);
        }

        if (_unitPrefabNames.ContainsKey(unitName))
            return _unitPrefabNames[unitName];
        else
        {
            Debug.LogError("Unit with name " + unitName + " not found in ObjectFactory!");
            return null;
        }
    }

}
