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
            var laneObject = settings.Obstacle;
            if (Random.Range(0f,1f) < settings.HealthKitChance)
            {
                laneObject = settings.HealthKit;
            }
            var lane = Random.Range(0, settings.Lanes);
            laneObject = Instantiate(laneObject, transform.position + Vector3.right * (lane * settings.LaneMargin), Quaternion.identity);
            _lastLaneObject = laneObject.GetComponent<LaneObject>();
        }
    }
}
