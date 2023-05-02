
using UnityEngine;

using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour {

    public void StartButt()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void BackButt()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
