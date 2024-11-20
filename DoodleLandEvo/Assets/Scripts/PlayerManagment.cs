using UnityEngine;
using TMPro;

public class PlayerManagment : MonoBehaviour
{
    public bool hasLegs = false;
    public GameObject EvolutionMenuCanvas;
    private bool isEvolutionMenuOpen = false;

    public TMP_Text scoreText;
    public int Score { get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        if (Input.GetKeyDown(KeyCode.P) && !isEvolutionMenuOpen)
        {
            OpenEvolutionMenu();
        }

        else if (isEvolutionMenuOpen && Input.GetKeyDown(KeyCode.P))
        {
            CloseEvolitionMenu();
        }
    }
    private void OpenEvolutionMenu()
    {
        isEvolutionMenuOpen = true;
        EvolutionMenuCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    private void CloseEvolitionMenu()
    {
        EvolutionMenuCanvas.SetActive(false);
        Time.timeScale = 1;
        isEvolutionMenuOpen = false;
    }

}
