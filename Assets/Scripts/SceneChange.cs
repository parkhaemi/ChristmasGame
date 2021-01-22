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

    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("Level02");
    }
    public void ChangeThirdScene()
    {
        SceneManager.LoadScene("Level03");
    }
    public void ChangeFourthScene()
    {
        SceneManager.LoadScene("Level04");
    }
    public void ChangeFifthScene()
    {
        SceneManager.LoadScene("Level05");
    }

    
    

}
