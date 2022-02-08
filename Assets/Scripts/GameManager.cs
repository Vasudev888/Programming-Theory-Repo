using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static string playerNameStr;
    public Text playerName;

    private void Start()
    {
        playerName.text = playerNameStr;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
