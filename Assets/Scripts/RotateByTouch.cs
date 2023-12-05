using UnityEngine;

public class RotateByTouch : MonoBehaviour
{
    [SerializeField] private bool rotateFromAnyPoint;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private float _maxDistance;
    private Touch _touch;
    private Vector2 _touchPosition;
    private Quaternion _rotation;
    private RaycastHit _raycastHit;

    private void Update()
    {
        if (rotateFromAnyPoint) Rotate();
        else if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out _raycastHit, _maxDistance))
        {
            if (_raycastHit.collider.gameObject == gameObject)
            {
                Rotate();
            }
        }
    }

    private void Rotate()
    {
        if (Input.touchCount >= 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Moved)
            {
                
            }
        }
    }
}
