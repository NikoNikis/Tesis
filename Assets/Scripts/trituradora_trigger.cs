using UnityEngine;

public class trituradora_trigger : MonoBehaviour
{
    public GameObject trituradora, bloqueador, nextActividad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trituradora.SetActive(true);
            bloqueador.SetActive(false);
            nextActividad.SetActive(true);
        }
    }
}
