using UnityEngine;

public class Offset_mover : MonoBehaviour
{
    public float scrollSpeed = 0.1f; // Velocidad del desplazamiento
    private Renderer objRenderer;   // Renderer del objeto
    private Vector2 offset;         // Offset actual de la textura
    bool mesaplana=false;
    public GameObject sfx;

    void Start()
    {
        // Obtén el Renderer del objeto
        objRenderer = GetComponent<Renderer>();
        if (objRenderer == null)
        {
            Debug.LogError("Este objeto no tiene un Renderer asignado.");
        }
    }

    void Update()
    {
        if (objRenderer != null && mesaplana==true)
        {
            // Calcula el nuevo offset basado en el tiempo y la velocidad
            offset = objRenderer.material.mainTextureOffset;
            offset.x -= scrollSpeed * Time.deltaTime;

            // Asigna el nuevo offset al material
            objRenderer.material.mainTextureOffset = offset;
        }
    }
    public void encender_mesaplana()
    {
        mesaplana = true;
        sfx.GetComponent<SFXcontroller>().bien();
    }
}
