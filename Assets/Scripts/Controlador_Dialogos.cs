using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class Controlador_Dialogos : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip bienvenida, despedida;
    public AudioClip[] actividad;
    public AudioClip[] extraAudio;
    public AudioClip[] actividad_completada;
    public Action[] actividades;
    public Action[] extras;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(BienvenidaContador());
        actividades = new Action[] { actividad1, actividad2, actividad3, actividad4, actividad5, actividad6, actividad7};
        extras = new Action[] { extra1, extra2 };
    }
    IEnumerator BienvenidaContador()
    {
        yield return new WaitForSeconds(1f);
        audioSource.clip = bienvenida;
        audioSource.Play();
    }
    public void actividad1()
    {
        audioSource.clip = actividad[0];
        audioSource.Play();
    }
    public void actividad1completada()
    {
        audioSource.clip = actividad_completada[0];
        audioSource.Play();
    }
    public void actividad2()
    {
        audioSource.clip = actividad[1];
        audioSource.Play();
    }
    public void actividad2completada()
    {
        audioSource.clip = actividad_completada[1];
        audioSource.Play();
    }
    public void actividad3()
    {
        audioSource.clip = actividad[2];
        audioSource.Play();
    }
    public void actividad3completada()
    {
        audioSource.clip = actividad_completada[2];
        audioSource.Play();
    }
    public void actividad4()
    {
        audioSource.clip = actividad[3];
        audioSource.Play();
    }
    public void actividad4completada()
    {
        audioSource.clip = actividad_completada[3];
        audioSource.Play();
    }
    public void actividad5()
    {
        audioSource.clip = actividad[4];
        audioSource.Play();
    }
    public void actividad5completada()
    {
        audioSource.clip = actividad_completada[4];
        audioSource.Play();
    }
    public void actividad6()
    {
        audioSource.clip = actividad[5];
        audioSource.Play();
    }
    public void actividad6completada()
    {
        audioSource.clip = actividad_completada[5];
        audioSource.Play();
    }
    public void actividad7()
    {
        audioSource.clip = actividad[6];
        audioSource.Play();
    }
    public void actividad7completada()
    {
        audioSource.clip = actividad_completada[6];
        audioSource.Play();
    }
    public void DespedidaAudio()
    {
        audioSource.clip = despedida;
        audioSource.Play();
    }
    public void extra1()
    {
        audioSource.clip = extraAudio[0];
        audioSource.Play();
    }
    public void extra2()
    {
        audioSource.clip = extraAudio[1];
        audioSource.Play();
    }
}
