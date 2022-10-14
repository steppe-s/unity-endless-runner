using UnityEngine;

namespace _Scripts.Data
{
    [CreateAssetMenu]
    public class HighScore : ScriptableObject
    {
        [SerializeField] private float value;

        public float Value
        {
            get => value;
            set => this.value = Mathf.Max(this.value, value);
        }
    }
}
