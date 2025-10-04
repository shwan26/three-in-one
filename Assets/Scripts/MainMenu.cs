using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayDrivingGame()
    {
        SceneManager.LoadScene("DrivingScene");
    }

    public void PlayFlyingGame()
    {
        SceneManager.LoadScene("FlyingScene");
    }

    public void PlaySumoGame()
    {
        SceneManager.LoadScene("SumoScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}
