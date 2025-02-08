using UnityEngine;
using UnityEngine.InputSystem;

public class menu : MonoBehaviour
{
    private InputAction yButtonAction;
    private InputAction bButtonAction;
    public gamemanager gamemanager;

    private void Awake()
    {

        yButtonAction = new InputAction(binding: "<XRController>{LeftHand}/secondaryButton");
        bButtonAction = new InputAction(binding: "<XRController>{RightHand}/secondaryButton");


        yButtonAction.Enable();
        bButtonAction.Enable();
    }

    private void Update()
    {

        if (yButtonAction.WasPressedThisFrame())
        {
            Debug.Log("Boton Y presionado");

            gamemanager.tuto7();
        }


        if (bButtonAction.WasPressedThisFrame())
        {
            Debug.Log("Boton B presionado");
            gamemanager.tuto7();

        }
    }
}