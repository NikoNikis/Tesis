using UnityEngine;
using UnityEngine.InputSystem; 

public class MenuController : MonoBehaviour
{
    private InputAction yButtonAction;
    private InputAction bButtonAction;
    public GameObject menuUI;
    public float distanciaMenu = 1.0f;

    private void Awake()
    {
        
        yButtonAction = new InputAction(binding: "<XRController>{LeftHand}/secondaryButton"); 
        bButtonAction = new InputAction(binding: "<XRController>{RightHand}/secondaryButton"); 

        
        yButtonAction.Enable();
        bButtonAction.Enable();
    }

    private void Update()
    {
        if (yButtonAction.WasPressedThisFrame() || bButtonAction.WasPressedThisFrame())
        {
            menuUI.SetActive(!menuUI.activeSelf); // Activa/desactiva el menú
        }

        // Rotar el menú con la cámara
        if (menuUI.activeSelf)
        {
            // Obtener la dirección hacia adelante de la cámara
            Vector3 direccionCamara = Camera.main.transform.forward;

            // Proyectar la dirección en el plano XZ para ignorar la rotación vertical
            direccionCamara = Vector3.ProjectOnPlane(direccionCamara, Vector3.up);

            // Calcular la posición del menú en un círculo alrededor del jugador
            Vector3 posicionMenu = Camera.main.transform.position + direccionCamara * distanciaMenu;

            // Actualizar la posición y rotación del menú
            menuUI.transform.position = posicionMenu;
            menuUI.transform.rotation = Quaternion.LookRotation(direccionCamara, Vector3.up);
        }
    }
}
