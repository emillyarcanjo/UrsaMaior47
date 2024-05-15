using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainScene : MonoBehaviour
{
    private Button button;
    public int mode;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadMainScene);
    }

    public void LoadMainScene()
    {
        GameManager.Instance.mode = mode;
        SceneManager.LoadScene(1);
    }
}
