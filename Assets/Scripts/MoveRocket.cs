using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MoveRocket : MonoBehaviour  
{  
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 viewPos;

    void Update()  
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
    void LateUpdate(){
        viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -200f, 200f);
        viewPos.y = Mathf.Clamp(viewPos.y, -200f, 200f);
        viewPos.z = Mathf.Clamp(viewPos.z, -200f, 200f);
        transform.position = viewPos;
    }  
}  