using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveCamera : MonoBehaviour
{
    Vector2 moveVector;
    Vector2 rotateVector;

    public float moveSpeed = 8f;
    public float rotationSpeed = 100f;

    public GameObject Rocket;
    private Vector3 offset;
    public float smoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        offset = transform.position - Rocket.transform.position;
    }

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
        Vector3 targetPosition = Rocket.transform.position + Rocket.transform.localRotation * offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
    private void HandleInputSystemControls()
    {

        if ((rotateVector.x < 0 && Mathf.Abs(rotateVector.x) > Mathf.Abs(rotateVector.y)) || moveVector.x < 0)
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, -0.5f); //esquerda
        }

        if ((rotateVector.x > 0 && Mathf.Abs(rotateVector.x) > Mathf.Abs(rotateVector.y)) || moveVector.x > 0)
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, 0.5f); //direita
        }

        if (rotateVector.y > 0 && Mathf.Abs(rotateVector.y) > Mathf.Abs(rotateVector.x))
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, 0.5f); //cima
        }

        if (rotateVector.y < 0 && Mathf.Abs(rotateVector.y) > Mathf.Abs(rotateVector.x))
        {

            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, -0.5f); //baixo
        }


    }
    private void HandleClassicControls()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, -0.5f); //esquerda
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, 0.5f); //direita
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, 0.5f); //cima
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, -0.5f); //baixo
        }
    }

}