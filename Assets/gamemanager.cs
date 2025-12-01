using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public void LoadGame() 
    {
        SceneManager.LoadScene("minigame");
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
