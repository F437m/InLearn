using TMPro;
using UnityEngine;

namespace SubjectScene
{
    public class SelectTarget : MonoBehaviour
    {
        public void Highlight(bool state)
        {
            this.GetComponent<TextMeshProUGUI>().color = state ? Color.cyan : Color.white;
        }
    }
}