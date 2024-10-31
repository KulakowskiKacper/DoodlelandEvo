using UnityEngine;

public class PickUpPoint : MonoBehaviour
{
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GetComponent<PlayerManagment>().Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            score++;
        }
    }
}
