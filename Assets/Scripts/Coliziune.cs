using UnityEngine;

public class Coliziune : MonoBehaviour
{
    public GameLogic gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Coliziune detectată!");
        if (collision.gameObject.CompareTag("GolfBall"))
        {
            gameManager.RegisterShot();
        }
    }
}