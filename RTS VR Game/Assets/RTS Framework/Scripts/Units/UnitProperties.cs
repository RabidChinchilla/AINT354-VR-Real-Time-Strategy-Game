using UnityEngine;

/// <summary>
/// Unit cargo hold inventory, properties such as health, speed, damage, range, etc.
/// Loaded from a file.
/// </summary>
public abstract class UnitProperties : ScriptableObject
{
    public int maxHealth;
    public int cost;
}
