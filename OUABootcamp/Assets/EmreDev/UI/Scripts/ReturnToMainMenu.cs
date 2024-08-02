using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // Örneğin, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numarası kullanılabilir

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
