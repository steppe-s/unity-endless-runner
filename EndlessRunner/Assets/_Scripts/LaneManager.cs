using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts
{
    public class LaneManager : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;

        private float _lastObstacle;

        private void Start()
        {
            _lastObstacle = Time.time;
        }

        private void Update()
        {
            if (!(_lastObstacle + settings.ObstacleInterval < Time.time)) return;
            Instantiate(settings.Obstacle, transform.position + Vector3.right * (Random.Range(1, settings.Lanes + 1) * settings.LaneMargin), Quaternion.identity);
            _lastObstacle = Time.time;
        }
    }
}
