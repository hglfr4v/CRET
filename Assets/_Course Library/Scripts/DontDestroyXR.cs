using UnityEngine;

public class DontDestroyXR : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}