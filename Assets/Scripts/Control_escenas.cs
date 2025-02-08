using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_escenas : MonoBehaviour
{
    public int escena;
    // Update is called once per frame
    void Update()
    {
        float val = GetComponent<HingeJoint>().angle;
        if (val >= 20)
        {
            SceneManager.LoadScene(escena);
        }
    }
}
