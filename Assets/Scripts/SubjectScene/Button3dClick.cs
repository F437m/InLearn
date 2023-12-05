using UnityEngine;
using UnityEngine.Events;

namespace SubjectScene
{
    public class Button3dClick : MonoBehaviour
    {
        [SerializeField] private GameObject mainCamera;
        [SerializeField] private UnityEvent onClick;
        private GameObject _prevTarget;
    
        public void Update()
        {
            if (!Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out var raycast)) return;
            var target = raycast.transform.gameObject;
            if (!target.transform.CompareTag("item") && target != _prevTarget) return;
            target.GetComponent<SelectTarget>().Highlight(true);
            _prevTarget.GetComponent<SelectTarget>().Highlight(false);
            onClick.Invoke();
            _prevTarget = target;
        }
    }
}
