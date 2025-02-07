using UnityEngine;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class PlayerManagment : MonoBehaviour
{
    public string gameOverScene;
    public bool hasLegs = false;
    public GameObject EvolutionMenuCanvas;
    private bool isEvolutionMenuOpen = false;
    private static GameObject Instance;

    public TMP_Text scoreText;
    public int Score { get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            Instance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
        GameOver();
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

    private void GameOver()
    {
        if (transform.position.y  < - 6)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(gameOverScene);
        }
    }

}
