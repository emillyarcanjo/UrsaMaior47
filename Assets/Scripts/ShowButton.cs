using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour
{ 
    public Button button; 
    
    void Start()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            button.interactable = false;
        }
    }
}
