using UnityEngine;

public class toggle_actividades : MonoBehaviour
{
    public GameObject spawner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        spawner.SetActive(true);
    }
}
