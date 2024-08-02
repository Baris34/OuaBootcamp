using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // �rne�in, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numaras� kullan�labilir

    void Update()
    {
        // "P" tu�una bas�ld���nda sahne de�i�tirilir
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneName);
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
