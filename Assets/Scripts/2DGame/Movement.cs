using UnityEngine;

namespace Game2D.UI
{
    public class Movement : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rb;

        [SerializeField]
        private float _speed;

        private void Update()
        {
            if (Input.GetButton("Horizontal"))
                _rb.linearVelocity = new Vector2(_speed * Input.GetAxis("Horizontal"), _rb.linearVelocity.y);
            if (Input.GetButton("Vertical"))
                _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _speed * Input.GetAxis("Vertical"));
        }
    }
}

