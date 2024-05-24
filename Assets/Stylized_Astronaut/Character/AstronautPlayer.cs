using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

namespace AstronautPlayer
{
    public class AstronautPlayer : MonoBehaviour
    {
        private Animator anim;
        private CharacterController controller;
        public float speed = 600.0f;
        public float turnSpeed = 400.0f;
        private Vector3 moveDirection = Vector3.zero;
        public float gravity = 20.0f;
        private Rigidbody rb;
        private Vector2 movimento;
        private float turn = 0;

        private bool isJumping = false;

        void Start()
        {
            controller = GetComponent<CharacterController>();
            anim = gameObject.GetComponentInChildren<Animator>();
            rb = GetComponent<Rigidbody>();
        }

        public void SetMovimento(InputAction.CallbackContext value)
        {
            Vector2 movimentoInput = value.ReadValue<Vector2>();
            float moveInputVertical = movimentoInput.y;
            float moveInputHorizontal = movimentoInput.x;

            if (moveInputVertical != 0)
            {
                anim.SetInteger("AnimationPar", 1);
                moveDirection = transform.forward * moveInputVertical * speed;
            }
            else
            {
                anim.SetInteger("AnimationPar", 0);
                moveDirection = Vector3.zero;
            }
            turn = moveInputHorizontal;
        }

        public void SetPular(InputAction.CallbackContext value)
        {
            if (value.started && controller.isGrounded)
            {
                isJumping = true;
            }
        }
        void Update()
        {
            if (isJumping)
            {
                moveDirection.y = 3;
                isJumping = false;
            }

            controller.Move(moveDirection * Time.deltaTime);
            moveDirection.y -= gravity * Time.deltaTime;

            transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        }
    }
}