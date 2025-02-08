using UnityEngine;

public class Dispararcompactadora : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab; // Prefab del cubo
    [SerializeField] private Transform spawnPoint; // Punto donde aparecerá el cubo
    [SerializeField] private float launchForce = 10f; // Fuerza con la que será disparado
    [SerializeField] private float launchAngle = 25f; // Ángulo en el que será disparado

    public void OnLeverActivated()
    {
        // Spawn del cubo en la posición y rotación del spawnPoint
        GameObject spawnedCube = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);

        // Obtener el Rigidbody del cubo
        Rigidbody rb = spawnedCube.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Calcular dirección del disparo con el ángulo especificado
            Vector3 launchDirection = Quaternion.Euler(-launchAngle, 0, 0) * spawnPoint.forward;

            // Aplicar fuerza al cubo
            rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
        }
    }
}
