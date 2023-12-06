using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Registrate : MonoBehaviour
{
    [SerializeField] private GameObject email;
    [SerializeField] private GameObject Password;
    [SerializeField] private GameObject Name;
    [SerializeField] private string sceneName;

    public void Publish()
    {
        SceneManager.LoadScene(sceneName);
    }
}
