using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;

    public TMP_Text scoreText;

    void Start()
    {
        score = GetComponent<PlayerManagment>().Score;
    }


    void Update()
    {
        scoreText.text = score.ToString();
    }
}
