using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public GameObject ball;
    public GameObject targetHole;
    public float minDistanceToHole = 3.0f;
    private int shotCount = 0; 
    private bool gameEnded = false;
    public GameObject finalScore; 

    void Start()
    {
        finalScore = GameObject.Find("Score"); 
        finalScore.SetActive(false); 
    }

    void Update()
    {
        float distanceToHole = Vector3.Distance(ball.transform.position, targetHole.transform.position);
        if (!gameEnded && distanceToHole < minDistanceToHole)
        {
            Debug.Log("Mingea a ajuns în gaură! Total lovituri: " + shotCount);
            gameEnded = true;
            DisplayEndGameMessage();
        }
    }

    public void RegisterShot()
    {
        if (!gameEnded)
        {
            shotCount++;
            Debug.Log(shotCount/2);
        }
    }

    private void DisplayEndGameMessage()
    {
        Text textComponent = finalScore.GetComponent<Text>();
        if (textComponent != null)
        {
            textComponent.text = "You Win! Shots: " + shotCount / 2; 
            finalScore.SetActive(true); 
        }
        else
        {
            Debug.LogError("Componenta Text nu a fost găsită pe finalScore!");
        }
    }
}