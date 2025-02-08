using UnityEngine;

public class activar_molino : MonoBehaviour
{
    Trituradora_verificador verificador;
    private void Start()
    {
        verificador = GetComponent<Trituradora_verificador>();
        verificador.enabled = false;
    }
    public void activar_verificadora()
    {
        verificador.enabled = true;
    }
}
