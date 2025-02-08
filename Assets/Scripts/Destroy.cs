using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float altura;
    
    
    void Update()
    {
        if (transform.position.y < altura) { 
            Destroy(gameObject); 
        }
    }
}
