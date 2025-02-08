using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable_magico : MonoBehaviour
{
    public GameObject[] spheres; // Lista de esferas que forman el cable
    public GameObject cylinderPrefab; // Prefab del cilindro que será el "segmento del cable"

    private GameObject[] cylinders; // Array para almacenar los cilindros generados
    void Start()
    {
        if (spheres.Length < 2 || cylinderPrefab == null)
        {
            Debug.LogError("Asegúrate de tener al menos dos esferas y un prefab de cilindro asignado.");
            return;
        }

        // Crear cilindros entre cada par de esferas
        cylinders = new GameObject[spheres.Length - 1];
        for (int i = 0; i < spheres.Length - 1; i++)
        {
            cylinders[i] = Instantiate(cylinderPrefab, transform);
        }
    }

    
    void Update()
    {
        // Actualizar la posición, rotación y escala de los cilindros
        for (int i = 0; i < cylinders.Length; i++)
        {
            Vector3 startPoint = spheres[i].transform.position;
            Vector3 endPoint = spheres[i + 1].transform.position;

            // Calcular la posición del cilindro
            Vector3 midPoint = (startPoint + endPoint) / 2;
            cylinders[i].transform.position = midPoint;

            // Orientar el cilindro hacia la siguiente esfera
            Vector3 direction = endPoint - startPoint;
            cylinders[i].transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);



            // Ajustar la escala del cilindro para que conecte las esferas
            float distance = direction.magnitude;
            Vector3 scale = cylinders[i].transform.localScale;
            cylinders[i].transform.localScale = new Vector3(scale.x, distance / 2, scale.z);
        }
    }
}
