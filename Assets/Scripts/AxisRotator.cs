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
            RotateTo(Vector3.back);

        if (_inputHandler.IsTurningLeft)
            RotateTo(Vector3.forward);
    }

    private void RotateTo(Vector3 direction) 
        => _rigidbody.AddTorque(direction * _forceRotation, ForceMode.Force);
}