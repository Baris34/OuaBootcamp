using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // Örneðin, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numarasý kullanýlabilir

    void Update()
    {
        // "P" tuþuna basýldýðýnda sahne deðiþtirilir
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneName);
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
