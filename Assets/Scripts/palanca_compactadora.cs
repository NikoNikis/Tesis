using UnityEngine;

public class palanca_compactadora : MonoBehaviour
{
    public Dispararcompactadora dispararcompactadora;
    public Controlador_Dialogos controlador_dialogos;
    int cont;
    void Update()
    {
        float val = GetComponent<HingeJoint>().angle;
        if (val >= 90 && cont == 0)
        {
            dispararcompactadora.OnLeverActivated();
            controlador_dialogos.actividad1completada();
            cont = 1;
        }
        else if (val <= 10 && cont == 1)
        {
            cont = 0;
        }
    }
}
