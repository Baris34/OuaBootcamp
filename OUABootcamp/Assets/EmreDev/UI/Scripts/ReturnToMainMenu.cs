using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // Örneðin, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numarasý kullanýlabilir

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
