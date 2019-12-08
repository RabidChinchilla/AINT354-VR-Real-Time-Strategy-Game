using UnityEngine;
using UnityEngine.UI;
using System.IO;

/// <summary>
/// Controls the load and save game menus.
/// </summary>
public abstract class ListMenuController : MonoBehaviour
{
    public const string SAVE_FOLDER = "Savegames";

    public RectTransform SavegameContainer;
    public GameObject ClickableItemPrefab;

    protected string _selectedFilename = null;

    /// <summary>
    /// Invoked when the Save or Load button has been clicked.
    /// </summary>
    public abstract void OnConfirm();

    /// <summary>
    /// Invoked when the Cancel button has been clicked.
    /// </summary>
    public void OnCancel()
    {
        transform.parent.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Invoked when the the Delete savegame button has been clicked.
    /// </summary>
    public void OnDelete()
    {
        if(Directory.Exists(SAVE_FOLDER) && File.Exists(SAVE_FOLDER + "/" + _selectedFilename))
            File.Delete(SAVE_FOLDER + "/" + _selectedFilename);

        OnEnable();
    }

    // Use this for initialization
    protected void OnEnable()
    {
        _selectedFilename = null;

        // Remove any present items
        foreach (Transform child in SavegameContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        // Add items
        string[] savegames = GetSavedGames();
        foreach (string path in savegames)
        {
            var filename = Path.GetFileName(path);
            GameObject clickableSavegame = Instantiate(ClickableItemPrefab, SavegameContainer);
            clickableSavegame.GetComponentInChildren<Text>().text = filename;
            clickableSavegame.GetComponent<Button>().onClick.AddListener(() => { OnSaveClicked(filename); });
        }
    }

    private void OnSaveClicked(string filename)
    {
        _selectedFilename = filename;
        foreach (Text comp in SavegameContainer.GetComponentsInChildren<Text>())
        {
            comp.color = filename == comp.text ? Color.yellow : Color.white;
        }
    }

    private string[] GetSavedGames()
    {
        // Load existing saves
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }

        return Directory.GetFiles(SAVE_FOLDER);
    }

}
