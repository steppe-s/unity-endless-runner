using System;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;
        [SerializeField] private UnityEvent<float> onScoreChange;
    
        private float _distance;

        private float Distance
        {
            get => _distance;
            set
            {
                _distance = value;
                onScoreChange.Invoke(_distance);
            }
        }

        private void Awake()
        {
            Distance = 0;
        }

        private void LateUpdate()
        {
            Distance += (settings.BaseObstacleSpeed + settings.ObstacleSpeedIncreaseOverSeconds * Time.timeSinceLevelLoad) * Time.deltaTime;
        }
    }
}
