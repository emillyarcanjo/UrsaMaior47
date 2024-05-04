using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainScene : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadMainScene);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
