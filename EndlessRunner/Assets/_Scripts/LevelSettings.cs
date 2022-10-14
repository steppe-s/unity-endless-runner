using UnityEngine;

namespace _Scripts
{
    [CreateAssetMenu]
    public class LevelSettings : ScriptableObject
    {
        [SerializeField] private int lanes;
        [SerializeField] private float laneMargin;
        [SerializeField] private float laneLength;
        [SerializeField] private float obstacleInterval;
        [SerializeField] private float firstObstacleDistance;
        [SerializeField] private float baseObstacleSpeed;
        [SerializeField] private GameObject obstacle;
        
        public int Lanes => lanes;

        public float LaneMargin => laneMargin;

        public float LaneLength => laneLength;

        public float ObstacleInterval => obstacleInterval;

        public float FirstObstacleDistance => firstObstacleDistance;

        public float BaseObstacleSpeed => baseObstacleSpeed;

        public GameObject Obstacle => obstacle;
    }
}
