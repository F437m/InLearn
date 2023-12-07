using UnityEngine;
using UnityEngine.SceneManagement;

public class LogIn : MonoBehaviour
{
    [SerializeField] private GameObject email;
    [SerializeField] private GameObject password;
    [SerializeField] private string sceneName;

    public void Publish()
    {
        PlayerPrefs.SetInt("Reg", 1);
        SceneManager.LoadScene(sceneName);
    }
}
