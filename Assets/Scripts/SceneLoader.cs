using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void LoadPrototype1()
    {
        SceneManager.LoadScene("Prototype1");
    }

    public void LoadPrototype2()
    {
        SceneManager.LoadScene("Prototype2");
    }

    public void LoadPrototype3()
    {
        SceneManager.LoadScene("Prototype3");
    }

    public void LoadPrototype4()
    {
        SceneManager.LoadScene("Prototype4");
    }

    public void LoadPrototype5()
    {
        SceneManager.LoadScene("Prototype5");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
