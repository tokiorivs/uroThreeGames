using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndQuiz : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI finalScoreText;
    float scorePercentil;
    ScoreKeeper scoreKeeper;
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Update()
    {
        ShowFinalScore();
    }
    void ShowFinalScore()
    {
        scorePercentil = scoreKeeper.ScorePercentil();

        finalScoreText.text = "Felicitaciones Respondiste El " + (int)scorePercentil + "% De Las Preguntas";
    }
}
