using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 5f;
    public float maxSpeed = 8f;

    float speed = 1f;

    void Start(){
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate(){
        Vector2 forward=new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition (rb.position + forward * Time.fixedDeltaTime);
    }

    
}
