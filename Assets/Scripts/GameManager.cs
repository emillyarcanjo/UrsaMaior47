using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int mode;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Faz com que o objeto persista entre as cenas
        }
        else
        {
            Destroy(gameObject); // Garante que não haverá duplicatas
        }
    }
}
