using UnityEngine;

namespace SubjectScene
{
    public class RotateByTouch : MonoBehaviour
    {
        [SerializeField] private float rotSpeed;
        [SerializeField] private GameObject mainCamera;
        private Touch _touch;
        private Quaternion _rotation;
    

        private void Update()
        {
            if(Input.touchCount >= 0)
            {
                var touch = Input.GetTouch(0);
                transform.Rotate(mainCamera.transform.right * (touch.deltaPosition.y * rotSpeed), Space.World);
                transform.Rotate(-mainCamera.transform.up   * (touch.deltaPosition.x * rotSpeed), Space.World);
            }
        }
    }
}
