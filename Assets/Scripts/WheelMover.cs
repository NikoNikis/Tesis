using UnityEngine;

public class WheelMover : MonoBehaviour
{
    public Transform wheel; // La rueda con HingeJoint
    public Transform objectToMove; // El objeto que se moverá
    public Transform[] engranajes;
    public float gearRotationFactor = 1f;
    public float gearRatio = 1f;  // Relación entre la rueda y los engranajes
    public float movementFactor = 0.1f; // Escala de movimiento
    public float movementFactorY = 0.2f; // Escala de movimiento
    public GameObject SFX, trigger;
    bool completado;
    public Controlador_Dialogos controladorDialogos;
    private float previousAngle = 0f;

    void Update()
    {
        // Obtener el ángulo actual de la rueda
        float currentAngle = wheel.localEulerAngles.z;

        // Ajustar el ángulo si excede 180 para evitar saltos bruscos
        if (currentAngle > 180) currentAngle -= 0;

        // Calcular el cambio en el ángulo
        float deltaAngle = currentAngle - previousAngle;

        // Mover el objeto en el eje Z
        Vector3 newPosition = objectToMove.position;
        newPosition.z += deltaAngle * movementFactor;
        newPosition.y += deltaAngle * (movementFactor* movementFactorY);
        objectToMove.position = newPosition;


        if (newPosition.z >= 23f && completado==false)
        {
            completado = true;
            SFX.GetComponent<SFXcontroller>().bien();
            controladorDialogos.actividad6completada();
            trigger.SetActive(true);
        }
        //engranajes[0].Rotate(Vector3.left, deltaAngle * gearRatio);  // Movimiento contrario si están engranados
        //Mover engranajes


        // Actualizar el ángulo anterior
        previousAngle = currentAngle;



        


    }
}
