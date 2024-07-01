using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // Switches scene
    {

        SceneManager.LoadScene(1);
    }

    public void QuitGame() // Quits
    {
        Application.Quit();
        Debug.Log("quit!");
    }
}
