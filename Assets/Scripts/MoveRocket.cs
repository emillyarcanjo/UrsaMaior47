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

    private Vector3 viewPos;

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
        if (GameManager.Instance != null && GameManager.Instance.mode == 1)
        {
            HandleInputSystemControls();

        }
        else
        {
            HandleClassicControls();

        }
    }

    void LateUpdate()
    {
        viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -200f, 200f);
        viewPos.y = Mathf.Clamp(viewPos.y, -200f, 200f);
        viewPos.z = Mathf.Clamp(viewPos.z, -200f, 200f);
        transform.position = viewPos;
    }

    private void HandleClassicControls()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * 0.2f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * 0.2f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -0.5f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 0.5f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0.0f, 0.0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.0f, 0.0f, -0.5f);
        }
    }

    private void HandleInputSystemControls()
    {

        transform.Translate(moveVector.y * 0.2f, 0, 0);

        if (lookVector.y > 0 && Mathf.Abs(lookVector.y) > Mathf.Abs(lookVector.x))
        {
            transform.Rotate(0.0f, 0.0f, 0.5f); //cima
        }

        if (lookVector.y < 0 && Mathf.Abs(lookVector.y) > Mathf.Abs(lookVector.x))
        {
            transform.Rotate(0.0f, 0.0f, -0.5f); //baixo
        }

        if ((lookVector.x < 0 && Mathf.Abs(lookVector.x) > Mathf.Abs(lookVector.y)) || moveVector.x < 0)
        {
            transform.Rotate(0.0f, -0.5f, 0.0f); //esquerda
        }

        if ((lookVector.x > 0 && Mathf.Abs(lookVector.x) > Mathf.Abs(lookVector.y)) || moveVector.x > 0)
        {
            transform.Rotate(0.0f, 0.5f, 0.0f); //direita
        }

    }

}
