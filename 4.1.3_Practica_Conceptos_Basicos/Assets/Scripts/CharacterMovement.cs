/* Created by: Fernanda Cortés & Arantza Parra 
03/09/23
Script created to give movement to the character
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit_x;
     [SerializeField] float limit_y;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     move.x= Input.GetAxis("Horizontal"); 
    Debug.Log("X montion: " + move.x);
     move.y= Input.GetAxis("Vertical");
    Debug.Log("Y montion: " + move.y);

    //Check if the character is in the permitted parameter, if so, move the character 
    if(transform.position.x < -limit_x && move.x < 0){
        move.x=0;

    } else if(transform.position.x > limit_x && move.x > 0){
        move.x=0;
    }
    
    if(transform.position.y < -limit_y && move.y < 0){
        move.y=0;

    } else if(transform.position.y > limit_y && move.y > 0){
        move.y=0;
    }
    transform.Translate(move * speed * Time.deltaTime);
   
}

   
}
