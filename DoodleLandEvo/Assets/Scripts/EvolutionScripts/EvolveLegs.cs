using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Collections;

public class EvolveLegs : MonoBehaviour
{

    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject[] playerLegs = new GameObject[2];
    [SerializeField] private Button button;
    public PlayerManagment playerManagment;
    public PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(Evolve);
    } //

    // Update is called once per frame
    void Update()
    {

    }


    private void Evolve()
    {
        if (playerManagment.Score >= 4)
        {
            playerObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
            playerManagment.Score -= 4;
            Time.timeScale = 1;
            StartCoroutine(Wait());
            IEnumerator Wait()
            {
                yield return new WaitForSeconds(1.0f);
                playerManagment.EvolutionMenuCanvas.SetActive(false);
                playerLegs[0].SetActive(true); //
                playerLegs[1].SetActive(true);
                playerManagment.hasLegs = true;
                playerMovement.speed = 5;
            }

        }
        else
        {
            Debug.Log("Not enough points");
        }
    }

}
