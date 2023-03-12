using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = CurrentScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
