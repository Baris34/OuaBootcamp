using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Burada sahnenizin ismini veya indeksini belirtin
    public string sceneName; // Örneğin, "TargetScene"
    //public int sceneIndex; // Alternatif olarak, indeks numarası kullanılabilir

    void Update()
    {
        // "P" tuşuna basıldığında sahne değiştirilir
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneName);
            // Alternatif olarak: SceneManager.LoadScene(sceneIndex);
        }
    }
}
