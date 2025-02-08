using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_UI : MonoBehaviour
{
    public GameObject menu;


    public void Reanudar()
    {
        menu.SetActive(false);
    }
    public void Lobby()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
