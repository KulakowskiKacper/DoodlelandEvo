using UnityEngine;

public class SetPlayerPosition : MonoBehaviour
{
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetPlayerToZero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPlayerToZero()
    {
        player.transform.position = new Vector3(0, 0, 0);
    }
}
