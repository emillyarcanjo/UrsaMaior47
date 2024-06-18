using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace AstronautThirdPersonCamera
{
    public class AstronautThirdPersonCamera : MonoBehaviour
    {
        public float Y_ANGLE_MIN = -10.0f;
        public float Y_ANGLE_MAX = 20.0f;
        public Transform lookAt;
        public Transform camTransform;
        public float distance = 80.0f;
        private float currentX = 0.0f;
        private float currentY = 0.0f;
        private float sensitivityX = 500.0f;
        private float sensitivityY = 125.0f;
        private Vector2 rightStickInput;

        private void Start()
        {
            camTransform = transform;
        }

        private void Update()
        {
            if (GameManager.Instance == null || GameManager.Instance.mode == 0)
            {
                HandleClassicControls();
            }
            
        }

        private void LateUpdate()
        {
            Vector3 dir = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
            camTransform.position = lookAt.position + rotation * dir;
            camTransform.LookAt(lookAt.position);
        }

        public void MoveCamera(InputAction.CallbackContext value)
        {
            Vector2 rightStickInput = value.ReadValue<Vector2>();
			currentX += rightStickInput.x * sensitivityX * Time.deltaTime;
            currentY += rightStickInput.y * sensitivityY * Time.deltaTime;
            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }

        private void HandleClassicControls()
        {
            sensitivityX = 20.0f;
            sensitivityY = 5.0f;
            currentX += Input.GetAxis("Mouse X") * sensitivityX;
            currentY += Input.GetAxis("Mouse Y") * sensitivityY;
            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

        }

    }
}