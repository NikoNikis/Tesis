using System.Collections;
using UnityEngine;


public class gamemanager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] tutorial;

    public GameObject move, turn, teleport;

    public CharacterController characterController; // Arrastra el CharacterController del jugador aquí
    public float velocidadMinima = 0.1f; // Velocidad mínima para activar el audio

    public float velocidadAngularMinima = 10f; // Velocidad angular mínima para activar el audio
    private Quaternion rotacionAnterior;

    public Transform jugador; // Arrastra el Transform del jugador aquí
    private Vector3 posicionAnterior;


    public GameObject puerta;


    int cont =0;
    bool siguiente=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionAnterior = jugador.position;
        rotacionAnterior = transform.rotation;

        audioSource = GetComponent<AudioSource>();
        StartCoroutine(bienvenida());
    }
    IEnumerator bienvenida()
    {
        yield return new WaitForSeconds(1f);
        audioSource.clip = tutorial[0];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[0].length);
        audioSource.clip = tutorial[1];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[1].length);
        move.SetActive(true);
        siguiente = true;
    }
    private void Update()
    {
        if (cont<=2)
        {
            // Obtener la velocidad del jugador
            float velocidad = characterController.velocity.magnitude;
            // Verificar si la velocidad es mayor que la velocidad mínima
            if (velocidad > velocidadMinima)
            {
                // Si el audio no se está reproduciendo, reprodúcelo
                if (!audioSource.isPlaying && cont == 0 && siguiente)
                {
                    StartCoroutine(tutorial1());

                }
            }

            // Calcular la diferencia de rotación entre frames
            float diferenciaRotacion = Quaternion.Angle(transform.rotation, rotacionAnterior);
            rotacionAnterior = transform.rotation;

            // Calcular la velocidad angular aproximada
            float velocidadAngular = diferenciaRotacion / Time.deltaTime;

            // Verificar si la velocidad angular es mayor que la velocidad mínima
            if (velocidadAngular > velocidadAngularMinima && cont == 1 && siguiente)
            {
                StartCoroutine(tutorial2());

            }

            // Detectar teletransportación solo si no hay rotación significativa
            if (Vector3.Distance(jugador.position, posicionAnterior) > 0.1f &&
                characterController.velocity.magnitude < velocidadAngularMinima && cont == 2 && siguiente)
            {
                StartCoroutine(tutorial3());

            }
        }
    }

    IEnumerator tutorial1()
    {
        siguiente = false;
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[2];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[2].length);
        audioSource.clip = tutorial[3];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[3].length);
        turn.SetActive(true);
        cont++;
        siguiente = true;
    }
    IEnumerator tutorial2()
    {
        siguiente = false;
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[4];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[4].length);
        audioSource.clip = tutorial[5];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[5].length);
        teleport.SetActive(true);
        cont++;
        siguiente = true;
    }
    IEnumerator tutorial3()
    {
        siguiente = false;
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[6];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[6].length);
        audioSource.clip = tutorial[7];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[7].length);
        cont++;
        siguiente = true;
    }
    IEnumerator tutorial4()
    {
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[8];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[8].length);
        audioSource.clip = tutorial[9];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[9].length);
    }
    IEnumerator tutorial5()
    {
        siguiente = false;
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[10];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[10].length);
        audioSource.clip = tutorial[11];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[11].length);
        siguiente = true;
        cont++;
    }
    IEnumerator tutorial6()
    {
        siguiente = false;
        Debug.Log("Accion completada");
        audioSource.clip = tutorial[12];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[12].length);
        audioSource.clip = tutorial[13];
        audioSource.Play();
        yield return new WaitForSeconds(tutorial[13].length);
        siguiente = true;
        cont++;
    }

    public void tuto4()
    {
        StartCoroutine(tutorial4());
    }

    public void tuto5()
    {
        if (cont == 3 && siguiente) 
        {
            StartCoroutine(tutorial5());
        }
    }
    public void tuto6()
    {
        if (cont == 4 && siguiente)
        {
            StartCoroutine(tutorial6());
        }
    }
    public void tuto7()
    {
        if (cont == 5 && siguiente)
        {
            audioSource.clip = tutorial[14];
            audioSource.Play();
            puerta.SetActive(true);
            cont++;
        }
    }

}
