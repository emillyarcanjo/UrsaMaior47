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

if (Input.GetKey(KeyCode.A))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, -0.5f);    
        }
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, 0.5f);   
        }
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, 0.5f);    
        }
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, -0.5f);    
        }
        Vector3 movement = new Vector3(moveVector.x, 0, moveVector.y);
        movement.Normalize();
        transform.Translate(moveSpeed * movement * Time.deltaTime, Space.Self);

        float horizontalRotation = rotateVector.x * rotationSpeed * Time.deltaTime;
        float verticalRotation = rotateVector.y * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, horizontalRotation, 0, Space.World);

    }


    void LateUpdate(){
        Vector3 targetPosition = Rocket.transform.position + Rocket.transform.localRotation*offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}