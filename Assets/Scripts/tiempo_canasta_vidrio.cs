using UnityEngine;

public class tiempo_canasta_vidrio : MonoBehaviour
{
    public GameObject contenido, particulas, sonidoBasura;
    private bool dadoVuelta = false; // Para verificar si el basurero está dado vuelta
    private float tiempoVuelta = 0f; // Tiempo acumulado mientras está dado vuelta
    public float tiempoParaVaciar = 3f; // Tiempo necesario para vaciar el basurero
    bool pulpeadora;
    public Controlador_Dialogos controladorDialogos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pulpeadora"))
        {
            pulpeadora = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("pulpeadora"))
        {
            pulpeadora = false;
        }
    }
    void Update()
    {
        if (transform.eulerAngles.x > 70 && transform.eulerAngles.x < 290 && pulpeadora == true) //orientación
        {
            if (!dadoVuelta)
            {
                dadoVuelta = true;
            }
            tiempoVuelta += Time.deltaTime;
            if (tiempoVuelta >= tiempoParaVaciar)
            {
                VaciarBasurero();
            }
        }
        else if (transform.eulerAngles.z > 70 && transform.eulerAngles.z < 290 && pulpeadora == true)
        {
            if (!dadoVuelta)
            {
                dadoVuelta = true;
            }

            tiempoVuelta += Time.deltaTime;

            // Vaciar el basurero si ha pasado suficiente tiempo
            if (tiempoVuelta >= tiempoParaVaciar)
            {
                VaciarBasurero();
                controladorDialogos.actividad2completada();
            }
        }
        else
        {
            // Reiniciar el estado si el basurero no está dado vuelta
            dadoVuelta = false;
            tiempoVuelta = 0f;
        }
        void VaciarBasurero()
        {
            particulas.SetActive(false); // Detiene las partículas
            sonidoBasura.GetComponent<AudioSource>().Stop();
            contenido.SetActive(false);//eliminar contenido del basurero
            sonidoBasura.GetComponent<OnTilt>().enabled = false;
            Debug.Log("El basurero está vacío");
        }
    }
}
