using UnityEngine;
using TMPro;

public class PlayerManagment : MonoBehaviour
{
    public TMP_Text scoreText;
    public int Score { get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Score);
        scoreText.text = Score.ToString();
    }

}
