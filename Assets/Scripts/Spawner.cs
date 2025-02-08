using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float time;
    private void Start()
    {
        StartCoroutine(bucle());
    }
    IEnumerator bucle()
    {
        while (true)
        {
            // Esperar X segundos
            yield return new WaitForSeconds(time);

            // Seleccionar un prefab aleatorio de la lista
            int randomIndex = Random.Range(0, prefabs.Length);
            GameObject prefabToSpawn = prefabs[randomIndex];

            // Instanciar el prefab en el punto de spawn
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
        }
    }
}
