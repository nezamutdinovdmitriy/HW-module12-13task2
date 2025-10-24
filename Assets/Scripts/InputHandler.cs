using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private readonly KeyCode _turningLeftKey = KeyCode.A;
    private readonly KeyCode _turningRightKey = KeyCode.D;

    public bool IsTurningLeft { get; private set; }
    public bool IsTurningRight { get; private set; }

    private void Update()
    {
        IsTurningLeft = Input.GetKey(_turningLeftKey);
        IsTurningRight = Input.GetKey(_turningRightKey);
    }
}