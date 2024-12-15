using Unity.VisualScripting;
using UnityEngine;

public class PickUpPoint : MonoBehaviour
{
    public PlayerManagment player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            player.Score++;
        }
    }
}
