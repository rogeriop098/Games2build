using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Corrida");
    }

    public void OpenSettings()
    {
        Debug.Log("Abrir Configurações");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }



}
