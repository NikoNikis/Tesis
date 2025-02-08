using UnityEngine;

public class Colisionparticulas : MonoBehaviour
{
    public string Tag;
    public GameObject sfx;
    int cont;
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag(Tag) && cont ==0)
        {
            sfx.GetComponent<SFXcontroller>().bien();
            cont++;
        }
    }
}
