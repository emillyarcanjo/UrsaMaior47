using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MoveRocket : MonoBehaviour  
{  
    void Update()  
    {  
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            transform.Translate(Vector3.left*0.1f);  
        }  
        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            transform.Translate(Vector3.right*0.1f);    
        }
        if (Input.GetKey(KeyCode.A))  
        {  
            transform.Rotate(0.0f,-0.5f,0.0f);    
        }
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.Rotate(0.0f,0.5f,0.0f);    
        }
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.Rotate(0f,0.0f,0.5f);    
        }
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.Rotate(0.0f,0.0f,-0.5f);    
        } 
    }  
}  