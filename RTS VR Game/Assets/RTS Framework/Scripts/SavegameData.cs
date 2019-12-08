using System;
using System.Collections.Generic;

[Serializable]
public class SavegameData
{
    public List<UnitData> PlayerUnits;
    public List<UnitData> AIUnits;
    public float CameraXPos, CameraYPos;
}

[Serializable]
public class UnitData
{
    public string Name;
    public int Armor;
    public float XPos, YPos;
    public int CurrentAction;
}
