using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public void ChangeToSeclctMap()
    {
        SceneManager.LoadScene("SelectMap");
    }

    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("Level01");
    }
}
