using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotaci�n
    private float targetAngle = 30f;  // �ngulo final
    private float startAngle = -89.98f; // �ngulo inicial
    private bool isRotating = false; // Control de rotaci�n
    public GameObject particulas, spawner;

    void Start()
    {
        // Inicializa el objeto en el �ngulo de inicio
        transform.rotation = Quaternion.Euler(startAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }

    void Update()
    {
        if (isRotating)
        {
            // Calcula el nuevo �ngulo de rotaci�n
            float currentAngle = transform.rotation.eulerAngles.x;
            if (currentAngle > 180f) currentAngle -= 360f; // Asegura que los �ngulos negativos sean manejados correctamente

            // Rota progresivamente el objeto hacia el �ngulo objetivo
            float newAngle = Mathf.MoveTowards(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(newAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

            // Detiene la rotaci�n cuando alcanza el �ngulo objetivo
            if (Mathf.Approximately(newAngle, targetAngle))
            {
                isRotating = false;
                particulas.GetComponent<ToggleParticle>().Play();
                spawner.SetActive(true);
            }
        }
    }

    // M�todo p�blico para iniciar la rotaci�n
    public void StartRotation()
    {
        isRotating = true;
    }
}
