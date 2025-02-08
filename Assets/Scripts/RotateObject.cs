using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotación
    private float targetAngle = 30f;  // Ángulo final
    private float startAngle = -89.98f; // Ángulo inicial
    private bool isRotating = false; // Control de rotación
    public GameObject particulas, spawner;

    void Start()
    {
        // Inicializa el objeto en el ángulo de inicio
        transform.rotation = Quaternion.Euler(startAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }

    void Update()
    {
        if (isRotating)
        {
            // Calcula el nuevo ángulo de rotación
            float currentAngle = transform.rotation.eulerAngles.x;
            if (currentAngle > 180f) currentAngle -= 360f; // Asegura que los ángulos negativos sean manejados correctamente

            // Rota progresivamente el objeto hacia el ángulo objetivo
            float newAngle = Mathf.MoveTowards(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(newAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

            // Detiene la rotación cuando alcanza el ángulo objetivo
            if (Mathf.Approximately(newAngle, targetAngle))
            {
                isRotating = false;
                particulas.GetComponent<ToggleParticle>().Play();
                spawner.SetActive(true);
            }
        }
    }

    // Método público para iniciar la rotación
    public void StartRotation()
    {
        isRotating = true;
    }
}
