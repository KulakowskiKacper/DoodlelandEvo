using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{

    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Camera");
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float distance = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

        if (temp > startpos + length)
        {
            startpos += length;
        }
        else if (temp < startpos - length)
        {
            startpos -= length;
        }
    }
}
