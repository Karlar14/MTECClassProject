using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
    public int score;
    // Start is called before the first frame update
    public void increment(int number)
    {

        score += number;
        scoreText.text = score.ToString();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
