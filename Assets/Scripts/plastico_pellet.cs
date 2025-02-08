using UnityEngine;

public class plastico_pellet : MonoBehaviour
{

    //llegar a 1.77
    HingeJoint pellet;
    public GameObject sfx,particulas,pelletObj;
    bool toggle = false;
    public Controlador_Dialogos ControladorDialogos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pellet=GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        float val = pellet.angle;
        if (val>=175 && toggle == false) 
        {
            sfx.GetComponent<SFXcontroller>().bien();
            particulas.GetComponent<ToggleParticle>().Play();
            pelletObj.SetActive(false);
            toggle = true;
            ControladorDialogos.actividad3completada();
        }
    }
}
