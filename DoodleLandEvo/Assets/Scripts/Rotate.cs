using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();   
    }

    private void RotateObject()
    {
        transform.Rotate(new Vector3(0, 1, 0));
    }
}
