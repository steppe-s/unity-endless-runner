using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts
{
    public class LaneManager : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;

        private LaneObject _lastLaneObject;
        
        private void Update()
        {
            if (_lastLaneObject && !(_lastLaneObject.DistanceFromOrigin() > settings.ObstacleInterval)) return;
            // var numberOfObstaclesToSpawn = Random.Range(1, settings.Lanes - 1);
            // for (int i = 0; i < numberOfObstaclesToSpawn; i++)
            // {
            var lane = Random.Range(0, settings.Lanes);
            var o = Instantiate(settings.Obstacle, transform.position + Vector3.right * (lane * settings.LaneMargin), Quaternion.identity);
            _lastLaneObject = o.GetComponent<LaneObject>();
            // }
        }
    }
}
