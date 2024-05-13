using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMove : MonoBehaviour
{
    private Vector2 moveVector;
    private Vector2 lookVector;

    public float moveSpeed = 8f;
    public float rotationSpeed = 100f;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookVector = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        Vector3 movement = new Vector3(moveVector.y, 0, -moveVector.x);
        movement.Normalize();
        transform.Translate(moveSpeed * movement * Time.deltaTime, Space.World);

        float horizontalRotation = lookVector.x * rotationSpeed * Time.deltaTime;
        float verticalRotation = lookVector.y * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, horizontalRotation, 0, Space.World);
        transform.Rotate(0, 0, verticalRotation, Space.World);
    }
}
