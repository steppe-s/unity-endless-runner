using System;
using UnityEngine;

namespace _Scripts
{
    public abstract class LaneObject : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;

        private Vector3 _origin;

        private void Start()
        {
            _origin = transform.position;
        }

        private void Update()
        {
            if (DistanceFromOrigin() > settings.LaneLength)
            {
                Destroy(gameObject);
                return;
            }
            transform.Translate(Vector3.back * (settings.BaseObstacleSpeed * Time.deltaTime));
        }

        public float DistanceFromOrigin()
        {
            return Vector3.Distance(_origin, transform.position);
        }

        public abstract void OnCollisionWithPlayer(Player player);
    }
}
