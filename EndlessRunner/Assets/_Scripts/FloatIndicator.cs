using System;
using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class FloatIndicator : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        
        public void Change(float value)
        {
            text.text = "" + value;
        }
    }
}
