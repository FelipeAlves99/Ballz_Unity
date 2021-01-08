using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private Vector3 lastVelocity;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        lastVelocity = rigidBody2D.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts [0].normal);

        rigidBody2D.velocity = direction * Mathf.Max(speed, 0f);
    }
}
