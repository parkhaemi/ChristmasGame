using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game_Manager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
