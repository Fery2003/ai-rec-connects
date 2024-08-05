using UnityEngine;

public class Conveyor : MonoBehaviour
{

    public float speed = 1.0f;

    public void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;

        if(rb != null)
        {
            Vector3 direction = transform.forward;
            rb.velocity = direction * speed;
        }
    }
}
