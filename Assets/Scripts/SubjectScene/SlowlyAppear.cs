using Unity.VisualScripting;
using UnityEngine; 

namespace SubjectScene
{
    public class SlowlyAppear : MonoBehaviour
    {
        [SerializeField] private float target;
        private float _transparency;
        [SerializeField] private float speed = 0.1f;

        public void Appear() 
        {
            target = 1;
        }
        public void Disappear()
        {
            target = 0;
        }
        private void Start()
        {
            this.AddComponent<CanvasGroup>();
        }

        private void Update()
        {
            GetComponent<CanvasGroup>().alpha = _transparency;
            _transparency = Mathf.Lerp(_transparency, target, speed);
            if (_transparency <= 0.025f && target == 0f) gameObject.SetActive(false);
        }
    }
}

