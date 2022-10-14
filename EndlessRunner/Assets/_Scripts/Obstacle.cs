using System;
using UnityEngine;

namespace _Scripts
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;

        private Vector3 _origin;

        private void Start()
        {
            _origin = transform.position;
        }

        private void Update()
        {
            if (Vector3.Distance(_origin, transform.position) > settings.LaneLength)
            {
                Destroy(gameObject);
                return;
            }
            transform.Translate(Vector3.back * (settings.BaseObstacleSpeed * Time.deltaTime));
        }
    }
}
