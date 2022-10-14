using System;
using _Scripts.Data;
using _Scripts.Lane;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private LevelSettings settings;
        
        [SerializeField] private float moveSpeed;
        [SerializeField] private int baseHealth;

        private int _health;
        private Vector3 _origin;
        private int _position;

        [SerializeField] private UnityEvent<float> onHealthChange;
        [SerializeField] private UnityEvent onDeath;

        private int Position
        {
            get => _position;
            set => _position = Mathf.Clamp(value, 0, settings.Lanes - 1);
        }

        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                onHealthChange.Invoke(value);
                if (_health <= 0) Die();
            }
        }

        private Controls _controls;
        private Controls Controls
        {
            get
            {
                if (_controls != null)
                {
                    return _controls;
                }
                return _controls = new Controls();
            }
        }

        private void Awake()
        {
            Health = baseHealth;
        }

        private void Start()
        {
            _origin = transform.position;
            Controls.Enable();
            Controls.Player.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        }

        private void Move(Vector2 input)
        {
            Position += Mathf.RoundToInt(input.x);
        }

        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, _origin + Vector3.right * (_position * settings.LaneMargin), Time.deltaTime * moveSpeed);
        }

        private void OnTriggerEnter(Collider other)
        {
            var laneObject = other.GetComponent<LaneObject>();
            if (laneObject)
            {
                laneObject.OnCollisionWithPlayer(this);
            }
        }

        private void Die()
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }
}
