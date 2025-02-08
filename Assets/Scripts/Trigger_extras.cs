using UnityEngine;

public class Trigger_extras : MonoBehaviour
{
    public int extra;
    public Controlador_Dialogos controladorDialogos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controladorDialogos.extras[extra - 1]();
            gameObject.SetActive(false);
        }
    }
}
