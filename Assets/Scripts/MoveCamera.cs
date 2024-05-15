using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveVector;
    Vector2 rotateVector;

    public float moveSpeed = 8f;
    public float rotationSpeed = 100f;

    public void InputPlayer(InputAction.CallbackContext _context)
    {
        moveVector = _context.ReadValue<Vector2>();
    }

    public void InputRotate(InputAction.CallbackContext _context)
    {
        rotateVector = _context.ReadValue<Vector2>();
    }

    private void Update()
    {

        Vector3 movement = new Vector3(moveVector.x, 0, moveVector.y);
        movement.Normalize();
        transform.Translate(moveSpeed * movement * Time.deltaTime, Space.Self);

        float horizontalRotation = rotateVector.x * rotationSpeed * Time.deltaTime;
        float verticalRotation = rotateVector.y * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, horizontalRotation, 0, Space.World);

    }
}