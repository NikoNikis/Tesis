using System;
using UnityEngine;

public class Trituradora_verificador : MonoBehaviour
{
    int contador;
    public int cont_maximo;
    public GameObject sfx, spawner, toggle_actividad2;
    public string tag1, tag2, tag3; //tag1 equivale al que debe pasar como bien, mientras que tag2 y tag3 a los que no
    public Boolean cont_si;
    public Controlador_Dialogos ControladorDialogos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag1))
        {
            if (cont_si)
            {
                contador++;
                Debug.Log(contador);    
            }
            if (contador< cont_maximo) 
            {
                sfx.GetComponent<SFXcontroller>().bien();
            }
            else
            {
                sfx.GetComponent<SFXcontroller>().completado();
                spawner.SetActive(false);
                toggle_actividad2.SetActive(true);
                GameObject[] objectsToDestroy1 = GameObject.FindGameObjectsWithTag(tag1);
                GameObject[] objectsToDestroy2 = GameObject.FindGameObjectsWithTag(tag2);
                GameObject[] objectsToDestroy3 = GameObject.FindGameObjectsWithTag(tag3);
                foreach (GameObject obj in objectsToDestroy1)
                {
                    Destroy(obj);
                }
                foreach (GameObject obj in objectsToDestroy2)
                {
                    Destroy(obj);
                }
                foreach (GameObject obj in objectsToDestroy3)
                {
                    Destroy(obj);
                }
                ControladorDialogos.actividad1completada();
            }
        }
        else if (other.gameObject.CompareTag(tag2) || other.gameObject.CompareTag(tag3))
        {
            sfx.GetComponent<SFXcontroller>().mal();
        }
    }
}
