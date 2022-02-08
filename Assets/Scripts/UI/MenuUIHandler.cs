using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] public Text userNameText;
    [SerializeField] private Color userColor;



    private void Awake()
    {
        inputField.text = MainManager.instance.userName;
        
    }


    public void StartGame()
    {
        MainManager.instance.name = inputField.text;
        GameManager.playerNameStr = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        MainManager.instance.SaveName();
        Application.Quit();
    }
}
