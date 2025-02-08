using UnityEngine;

public class desactivarcubo : MonoBehaviour
{
    public string tag;
    public int actividad;
    public Controlador_Dialogos dialogos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            dialogos.actividades[actividad - 1]();
            gameObject.SetActive(false);
        }
    }

}
