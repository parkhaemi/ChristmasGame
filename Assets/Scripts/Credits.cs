using UnityEngine;

public class Credits : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
