using UnityEngine;

public class Trigger_audios : MonoBehaviour
{
    public int actividad;
    public Controlador_Dialogos controladorDialogos;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controladorDialogos.actividades[actividad - 1]();
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controladorDialogos.actividades[actividad - 1]();
            gameObject.SetActive(false);
        }
    }
}
