using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AxisRotator : MonoBehaviour
{
    [SerializeField] private float _forceRotation;
    [SerializeField] private InputHandler _inputHandler;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_inputHandler.IsTurningRight)
            Rotate(Vector3.back);

        if (_inputHandler.IsTurningLeft)
            Rotate(Vector3.forward);
    }

    private void Rotate(Vector3 direction) 
        => _rigidbody.AddTorque(direction * _forceRotation, ForceMode.Force);
}