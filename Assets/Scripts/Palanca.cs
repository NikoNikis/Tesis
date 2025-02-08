using UnityEngine;

public class Palanca : MonoBehaviour
{
    public GameObject actividad,trigger;
    int cont = 0;
    public Controlador_Dialogos ControladorDialogos;
    // Update is called once per frame
    void Update()
    {
        float val = GetComponent<HingeJoint>().angle;
        if (val>=90 && cont==0)
        {
            actividad.GetComponent<AudioSource>().Play();
            ControladorDialogos.actividad4completada();
            trigger.SetActive(true);
            cont = 1;
        }
        else if (val<=10 && cont ==1)
        {
            cont = 0;
            actividad.GetComponent<AudioSource>().Stop();
        }
    }
}
