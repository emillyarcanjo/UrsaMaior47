using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmillySceneOpen : MonoBehaviour
{
     private void OnMouseDown(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
    }
}
