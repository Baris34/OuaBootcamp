using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSettings : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene("Settings");
    }
}
