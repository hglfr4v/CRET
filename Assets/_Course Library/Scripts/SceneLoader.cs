using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("Scene Settings")]
    public string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            Debug.LogWarning("iam here");
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty");
        }

    }
}

