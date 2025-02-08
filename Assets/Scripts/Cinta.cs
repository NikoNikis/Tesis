using UnityEngine;

public class Cinta : MonoBehaviour
{
    public float speed;
    public Vector3 MovPos;
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += MovPos * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }
}
