/* Created by: Fernanda Cortés & Arantza Parra 
03/09/23
Script created to give continue movement (back and forth) to the enemies. 
*/
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public Rigidbody2D rb;

//Create a maximum and minimum speed for the enemies 
    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    void Start(){
        //Generate a random speed between the minimum and the maximum  for the enemies 
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate(){
        // Generate the direction and speed that the enemy will follow
        Vector2 forward=new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition (rb.position + forward * Time.fixedDeltaTime);
    }

    
}
