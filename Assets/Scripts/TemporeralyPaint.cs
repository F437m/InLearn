using UnityEngine;

public class TemporeralyPaint : MonoBehaviour
{
    [SerializeField] private int subjectID;
    [SerializeField] private GameObject rayOrigin;
    private bool _state;
    private void Update()
    {
        var color = new Color(0.2f, 0, 1);
        if (!Physics.Raycast(rayOrigin.transform.position, Vector3.forward, out var hit)) return;
        if (!hit.transform.CompareTag("Target")) Rotation3d.SubjectID = 0;
        _state = hit.transform.gameObject == gameObject;
        GetComponent<Renderer>().material.color = _state ? color : Color.white;
        if (!_state) return;
        Rotation3d.SubjectID = subjectID;
        Debug.Log(Rotation3d.SubjectID);
    }
}
