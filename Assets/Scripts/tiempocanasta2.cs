using UnityEngine;
using System.Collections;

public class tiempocanasta2 : MonoBehaviour
{
    public GameObject contenido, particulas, sonidoBasura;
    private bool dadoVuelta = false; // Para verificar si el basurero está dado vuelta
    private float tiempoVuelta = 0f; // Tiempo acumulado mientras está dado vuelta
    public float tiempoParaVaciar = 3f; // Tiempo necesario para vaciar el basurero
    bool pulpeadora;
    public Controlador_Dialogos controladorDialogos;
    public GameObject boton;
    public float temp = 6f;
    public ToggleParticle cerni1, cerni2;

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
        // Verificar si el objeto está dado vuelta
        if (transform.eulerAngles.x > 70 && transform.eulerAngles.x < 290 && pulpeadora == true) //orientación
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
                controladorDialogos.actividad3();
                cerni1.Play();
                cerni2.Play();
                boton.SetActive(true);
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