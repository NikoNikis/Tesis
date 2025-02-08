using UnityEngine;

public class LookXROrigin : MonoBehaviour
{
    // Referencia al XR Origin
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            
            transform.LookAt(target);

            
            transform.Rotate(0, 180, 0);
        }
        else
        {
            Debug.LogWarning("El objeto Target no está asignado.");
        }
    }
}
