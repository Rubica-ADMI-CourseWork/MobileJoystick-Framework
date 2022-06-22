using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Receives Movement direction input from the Joystick Controls
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    JoystickController joystickController;
    [field:SerializeField]public Vector2 MovementInput { get;private set; }

    private void OnEnable()
    {
        joystickController = FindObjectOfType<JoystickController>();
    }
    private void Start()
    {
        joystickController.OnMove += SetInput;
    }

    private void Update()
    {
        float horizontalInput = MovementInput.x;
        float upDownInput = MovementInput.y;

        
        transform.Rotate(Vector3.up * horizontalInput * 10f * Time.deltaTime);

        transform.Translate(Vector3.forward * upDownInput * 10f * Time.deltaTime);
    }
    private void SetInput(Vector2 movement)
    {
        MovementInput = movement;
    }
}
