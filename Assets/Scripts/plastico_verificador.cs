using UnityEngine;

public class plastico_verificador : MonoBehaviour
{
    int cont=0;
    public int cont_max;
    public string tag;
    public GameObject GameObject;
    bool toggle=false;
    public Controlador_Dialogos ControladorDialogos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {
            cont++;
            if (cont >= cont_max && toggle==false)
            {
                GameObject.SetActive(true);
                toggle = true;
                ControladorDialogos.actividad1();
            }
        }
    }
}
