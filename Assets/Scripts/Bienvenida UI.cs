using UnityEngine;
using UnityEngine.SceneManagement;

public class BienvenidaUI : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene(5);
    }
    public void No()
    {
        gameObject.SetActive(false);
    }
}
