using UnityEngine;

namespace _Scripts.Data
{
    [CreateAssetMenu]
    public class LevelSettings : ScriptableObject
    {
        [SerializeField, Min(2)] private int lanes;
        [SerializeField] private float laneMargin;
        [SerializeField] private float laneLength;
        [SerializeField] private float obstacleInterval;
        [SerializeField] private float baseObstacleSpeed;
        [SerializeField] private float obstacleSpeedIncreaseOverSeconds;
        [SerializeField] private GameObject healthKit;
        [SerializeField] private GameObject obstacle;
        [SerializeField, Range(0f, 1f)] private float healthKitChance;
        public int Lanes => lanes;

        public float LaneMargin => laneMargin;

        public float LaneLength => laneLength;

        public float ObstacleInterval => obstacleInterval;

        public float BaseObstacleSpeed => baseObstacleSpeed;

        public float ObstacleSpeedIncreaseOverSeconds => obstacleSpeedIncreaseOverSeconds;

        public GameObject HealthKit => healthKit;

        public GameObject Obstacle => obstacle;

        public float HealthKitChance => healthKitChance;
    }
}
