using UnityEngine;
using UnityEngine.SceneManagement;

public class AstronautRocketInteraction : MonoBehaviour
{
    public Transform astronaut;
    public float distanceThreshold = 4f;

    private void Update()
    {

        if (Vector3.Distance(transform.position, astronaut.position) < distanceThreshold)
        {
             SceneManager.LoadScene(1);
        }
    }
}
