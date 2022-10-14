using System;
using _Scripts.Data;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;
        [SerializeField] private UnityEvent<float> onScoreChange;
        [SerializeField] private UnityEvent<float> onHighScoreChange;
        [SerializeField] private HighScore highScore;
        
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
            onHighScoreChange.Invoke(highScore.Value);
        }

        private void LateUpdate()
        {
            Distance += (settings.BaseObstacleSpeed + settings.ObstacleSpeedIncreaseOverSeconds * Time.timeSinceLevelLoad) * Time.deltaTime;
            if (!(Distance > highScore.Value)) return;
            highScore.Value = Distance;
            onHighScoreChange.Invoke(highScore.Value);
        }
    }
}
