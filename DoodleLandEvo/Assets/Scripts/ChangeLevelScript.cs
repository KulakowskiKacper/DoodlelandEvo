using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelScript : MonoBehaviour
{
    public string levelName;

    private void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DontDestroyOnLoad(collision.gameObject);
            SceneManager.LoadScene(levelName);
            
        }
    }

}
