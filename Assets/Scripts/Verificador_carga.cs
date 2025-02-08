using UnityEngine;

public class Verificador_carga : MonoBehaviour
{
    int cont=-1;
    public string tag_comparado;
    public GameObject[] rollos;
    public GameObject spawner,sfx;
    public Controlador_Dialogos ControladorDialogos;
    public int conteo=14;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag_comparado))
        {
            cont++;
            rollos[cont].SetActive(true);
            other.gameObject.SetActive(false);
            if (cont == conteo)
            {
                spawner.SetActive(false);
                sfx.GetComponent<SFXcontroller>().bien();
                GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(tag_comparado);
                ControladorDialogos.actividad7completada();
                foreach (GameObject obj in objectsToDestroy)
                {
                    Destroy(obj);
                }
            }
        }
    }
}
