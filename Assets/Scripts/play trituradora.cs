using UnityEngine;

public class playtrituradora : MonoBehaviour
{
    public string Tag;
    public GameObject[] gameObjects;
    public ToggleParticle ToggleParticle;
    public Controlador_Dialogos controladorDialogos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].GetComponent<Girar_aspas>().activar();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tag))
        {
            ToggleParticle.Play();
            controladorDialogos.actividad2completada();
            Destroy(other);
        }
    }
}
