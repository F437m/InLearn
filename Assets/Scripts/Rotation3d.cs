using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation3d : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private TextMeshProUGUI subjectName;
    public static int SubjectID;
    private Touch _touch;
    private Quaternion _rotation;
    private readonly string[] _subjects = {"", "Физика", "Математка", "Информатика"};
    
    private void Update()
    {
        if (Input.touchCount < 0) return;
        var touch = Input.GetTouch(0);
        transform.Rotate(mainCamera.transform.right * (touch.deltaPosition.y * rotSpeed), Space.World);
        transform.Rotate(-mainCamera.transform.up   * (touch.deltaPosition.x * rotSpeed), Space.World);
        
        subjectName.text = _subjects[SubjectID];
        Debug.Log("=" + SubjectID);
    }

    [SerializeField] private string subjectScene;

    public void Choose()
    {
        if (SubjectID == 0) return;
        PlayerPrefs.SetInt("subject", SubjectID);
        SceneManager.LoadScene(subjectScene);
    }
}
