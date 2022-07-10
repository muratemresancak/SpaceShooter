using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void btn(int gbtn)
    {
        if (gbtn==1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (gbtn==2)
        {
            Application.Quit();
        }
    }
}
