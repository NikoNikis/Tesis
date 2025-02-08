using UnityEngine;

public class Dispararcompactadora : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab; // Prefab del cubo
    [SerializeField] private Transform spawnPoint; // Punto donde aparecer� el cubo
    [SerializeField] private float launchForce = 10f; // Fuerza con la que ser� disparado
    [SerializeField] private float launchAngle = 25f; // �ngulo en el que ser� disparado

    public void OnLeverActivated()
    {
        // Spawn del cubo en la posici�n y rotaci�n del spawnPoint
        GameObject spawnedCube = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);

        // Obtener el Rigidbody del cubo
        Rigidbody rb = spawnedCube.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Calcular direcci�n del disparo con el �ngulo especificado
            Vector3 launchDirection = Quaternion.Euler(-launchAngle, 0, 0) * spawnPoint.forward;

            // Aplicar fuerza al cubo
            rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
        }
    }
}
