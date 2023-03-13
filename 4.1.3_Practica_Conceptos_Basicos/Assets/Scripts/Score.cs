using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
// Establish the Score to zero. 
    public static int CurrentScore = 0;

   // Create a text where the Score will be save  
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = CurrentScore.ToString(); //Link the value that is save in Current store to the text seen in the scene

    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
