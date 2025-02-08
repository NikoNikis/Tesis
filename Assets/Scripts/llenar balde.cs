using UnityEngine;

public class llenarbalde : MonoBehaviour
{

    public string tag;
    public int actividad;
    public GameObject balde;
    public Controlador_Dialogos dialogos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            dialogos.actividades[actividad - 1]();
            balde.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
