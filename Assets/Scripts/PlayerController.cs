using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private FixedJoystick _joystick;
        [SerializeField] private ChangeAnimation _changeAnimation;

        [SerializeField] private float _moveSpeed;

        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

            if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
            {
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
                _changeAnimation.Moving(1);
            }
            else
                _changeAnimation.Moving(0);

        }
    }
}
