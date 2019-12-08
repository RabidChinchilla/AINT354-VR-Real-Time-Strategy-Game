using System;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveMenuController : ListMenuController
{
    public InputField FilenameInput;
    public AICommander aiCommander;

    public override void OnConfirm()
    {
        string filename = FilenameInput.text == ""
            ? DateTime.Now.ToString("yyyy-dd-MM-HH-mm-ss") 
            : FilenameInput.text;

        FileStream stream = new FileStream(SAVE_FOLDER + "/" + filename, FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, GetSavegameData());
        stream.Close();

        Debug.Log("Game saved!");
        OnEnable();

        OnCancel();
    }

    private SavegameData GetSavegameData()
    {
        List<GameObject> aiUnits = aiCommander.GetAIUnits();
        List<GameObject> playerUnits = BuildUnits.Instance.PlayerUnits;

        List<UnitData> aiUnitData = new List<UnitData>();
        List<UnitData> playerUnitData = new List<UnitData>();

        foreach(GameObject unit in aiUnits)
        {
            aiUnitData.Add(GetUnitData(unit));
        }

        foreach (GameObject unit in playerUnits)
        {
            playerUnitData.Add(GetUnitData(unit));
        }

        SavegameData saveData = new SavegameData();
        saveData.AIUnits = aiUnitData;
        saveData.PlayerUnits = playerUnitData;
        saveData.CameraXPos = Camera.main.transform.position.x;
        saveData.CameraYPos = Camera.main.transform.position.z;

        return saveData;
    }

    private UnitData GetUnitData(GameObject unit)
    {
        UnitController unitController = unit.GetComponent<UnitController>();

        UnitData data = new UnitData();

        data.XPos = unit.transform.position.x;
        data.YPos = unit.transform.position.z;
        data.Name = unitController.UnitProperties.name;
        data.Armor = unitController.GetHealth();
        data.CurrentAction = unitController.GetAction();

        if (data.Name == "Tank")
            Debug.Log("POSITION SAVED: "+unit.transform.position);

        return data;
    }
}
