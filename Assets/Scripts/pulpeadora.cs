using UnityEngine;

public class pulpeadora : MonoBehaviour
{
    public GameObject cylinder; // Asigna el cilindro desde el editor
    public float rotationSpeed = 50f; // Velocidad de rotación (grados por segundo)

    private bool isRotating = false;
    
    void Update()
    {
        if (isRotating && cylinder != null)
        {
            // Rotar el cilindro alrededor de su eje Y
            cylinder.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
    public void ToggleRotation()
    {
        isRotating = !isRotating; // Alterna entre activar y desactivar la rotación
    }
}
