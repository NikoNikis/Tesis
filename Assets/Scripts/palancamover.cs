using UnityEngine;

public class palancamover : MonoBehaviour
{
    public HingeJoint hingeJoint; // Arrastra el Hinge Joint aqui en el inspector
    public Transform objetoAMover; // Arrastra el objeto que quieres mover aqu�
    public float posicionInicial; // Posici�n inicial del objeto en el eje Z
    public float posicionFinal; // Posicion final del objeto en el eje Z
    public float val;
    public Dispararcompactadora dispararcompactadora;
    int cont=0;
    public GameObject trigger;
    private void Start()
    {
        posicionInicial = objetoAMover.position.y;
        posicionFinal = posicionInicial+val;
    }



    private void Update()
    {
        // Obtener el �ngulo actual del Hinge Joint
        float anguloActual = hingeJoint.angle;

        // Normalizar el �ngulo entre 0 y 90 grados
        float anguloNormalizado = Mathf.InverseLerp(0f, 90f, anguloActual);

        // Calcular la nueva posici�n en Y
        float nuevaPosicionY = Mathf.Lerp(posicionInicial, posicionFinal, anguloNormalizado);

        // Mover el objeto
        objetoAMover.position = new Vector3(objetoAMover.position.x, nuevaPosicionY, objetoAMover.position.z);

        if (anguloActual >= 80 && cont==0)
        {
            cont++;
            Debug.Log("palanca bajada"+cont);
        }
        if (anguloActual<=10 && cont==1)
        {
            cont--;
            Debug.Log("palanca subida");
            dispararcompactadora.OnLeverActivated();
            trigger.SetActive(true);
        }
    }
}
