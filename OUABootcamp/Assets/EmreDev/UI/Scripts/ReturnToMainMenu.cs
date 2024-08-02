using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // �rne�in, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numaras� kullan�labilir

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
