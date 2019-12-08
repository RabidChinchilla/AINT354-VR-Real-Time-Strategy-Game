using UnityEngine;

/// <summary>
/// Controls the ingame menu which displays the save, load and exit game buttons.
/// </summary>
public class MenuController : MonoBehaviour
{
    public GameObject SaveMenu, LoadMenu, PauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!PauseMenu.activeInHierarchy);
            SaveMenu.SetActive(false);
            LoadMenu.SetActive(false);

            Camera.main.GetComponent<CameraMovement>().IsStopped = PauseMenu.activeInHierarchy;
        }
    }

    public void OnSaveGameClicked()
    {
        SaveMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void OnLoadGameClicked()
    {
        LoadMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void OnExitGameClicked()
    {
        Application.Quit();
    }

 
}
