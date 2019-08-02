using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static string bonusValue = "";
    Text score;
    Text bonus;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
       // bonus = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
        //bonus.text = bonusValue;
    }
}
