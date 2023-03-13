/* Created by: Fernanda Cortés & Arantza Parra 
03/09/23
Script created to add points if the player reaches the goal (safe area)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }
    //Created a trigger function that will activate when the player gets to the other side of the rainbow
    // Update is called once per frame
    void OnTriggerEnter2D() 
    {
        Debug.Log("YOU WON!"); // Message that apears on the console when the character wins
        Score.CurrentScore += 100; //Points added when the player reaches the goal 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reset the scene when the player reaches the other side of the rainbow so it can continue to earn points
    }
}
