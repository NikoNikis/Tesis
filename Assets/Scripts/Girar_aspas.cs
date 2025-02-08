using UnityEngine;

public class Girar_aspas : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public Vector3 rotationSpeed = new Vector3(0, 100, 0);
    bool activarA=false;

    // Update se llama una vez por frame
    void Update()
    {
        if(activarA) transform.Rotate(rotationSpeed * Time.deltaTime);
    }
    public void activar()
    {
        activarA = true;
    }
}

