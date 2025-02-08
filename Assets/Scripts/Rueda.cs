using UnityEngine;

public class Rueda : MonoBehaviour
{
    public Transform objAmover;
    
    public float moveScale;

    public Vector3 moveDirection;

    private void Start()
    {
        objAmover.localPosition = transform.localPosition;
    }

    void Update()
    {
        float angle = GetComponent<HingeJoint>().angle;
        Vector3 newPosition = moveDirection * angle * moveScale;
        objAmover.localPosition = newPosition;
    }
}
