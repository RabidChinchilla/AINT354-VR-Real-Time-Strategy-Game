using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadGameController : ListMenuController
{
    public AICommander aiCommander;

    public override void OnConfirm()
    {
        if (_selectedFilename == null)
            return;

        FileStream stream = new FileStream(SAVE_FOLDER + "/" + _selectedFilename, FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();
        SavegameData data = formatter.Deserialize(stream) as SavegameData;
        stream.Close();

        InitializeGame(data);

        Debug.Log("Game loaded!");
        OnEnable();

        OnCancel();
    }

    private void InitializeGame(SavegameData data)
    {
        // Clear present units before spawning saved ones
        aiCommander.ClearAIUnits();
        foreach(var playerUnit in BuildUnits.Instance.PlayerUnits)
        {
            Destroy(playerUnit);
        }
        BuildUnits.Instance.PlayerUnits.Clear();

        // Spawn units
        GameObject unit;
        foreach(var unitData in data.AIUnits)
        {
            unit = SpawnUnitFromData(unitData);
            aiCommander.AddNewUnit(unit);
        }
        foreach (var unitData in data.PlayerUnits)
        {
            unit = SpawnUnitFromData(unitData);
            unit.transform.SetParent(BuildUnits.Instance.unitHolder.transform);
            BuildUnits.Instance.PlayerUnits.Add(unit);
        }
    
        Camera.main.transform.position = new Vector3(data.CameraXPos, Camera.main.transform.position.y, data.CameraYPos);
    }

    private GameObject SpawnUnitFromData(UnitData unitData)
    {
        GameObject unit = Instantiate(ObjectFactory.Instance.GetUnitByName(unitData.Name));
        unit.GetComponent<UnitController>().InitializeUnit(unitData);

        return unit;
    }

}
