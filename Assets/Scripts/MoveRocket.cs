using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRocket : MonoBehaviour
{
    private Vector2 moveVector;
    private Vector2 lookVector;

    public float moveSpeed = 8f;
    public float rotationSpeed = 100f;

    private void Update()
    {
        if (GameManager.Instance.mode == 0)
        {
            HandleClassicControls();
        }
        else
        {
            HandleInputSystemControls();
        }
    }

    private void HandleClassicControls()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.right * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -0.5f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 0.5f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0.0f, 0.0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0.0f, 0.0f, -0.5f);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookVector = context.ReadValue<Vector2>();
    }

    private void HandleInputSystemControls()
    {
        Vector3 movement = new Vector3(moveVector.y, 0, -moveVector.x);
        movement.Normalize();
        transform.Translate(moveSpeed * movement * Time.deltaTime, Space.Self);

        float horizontalRotation = lookVector.x * rotationSpeed * Time.deltaTime;
        float verticalRotation = lookVector.y * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, horizontalRotation, 0, Space.World);
        transform.Rotate(0, 0, verticalRotation, Space.World);
    }
}
