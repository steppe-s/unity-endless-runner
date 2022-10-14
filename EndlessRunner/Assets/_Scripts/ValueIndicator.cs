using System;
using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class ValueIndicator : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private string label;
        public void Change(float value)
        {
            text.text = label + ": " + Mathf.FloorToInt(value);
        }
    }
}
