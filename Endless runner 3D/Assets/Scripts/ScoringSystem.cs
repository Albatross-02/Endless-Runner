using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public Text Score;

    private float CurrentScore;
    // Start is called before the first frame update
    void Start()
    {
        CurrentScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        CurrentScore += Time.deltaTime * 3;
        Score.text = "Score : " + (int)CurrentScore;
    }
}
