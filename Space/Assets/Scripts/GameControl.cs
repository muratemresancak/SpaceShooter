using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject asteroid;
    public Text scoreText;
    public GameObject btn1;
    public GameObject btn2;
    bool isfinish = false;
 
    int score;
    void Start()
    {
        StartCoroutine(creating());
    }

   
    void Update()
    {
        
    }
    IEnumerator creating()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 1000; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-5.4f, 5.4f), 0, 18);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.3f);
                if (isfinish)
                {
                    i = 1000;
                 
                }
            }
            break;

        }




    }

    public void scoreup (int scr)
    {
        score += scr;
        scoreText.text = "Score " + score;
    }

    public void finish()
    {
        btn1.SetActive(true);
        btn2.SetActive(true);
        isfinish = true;
      
    }

    public void dbtn(int hbtn)
    {
        if (hbtn==1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (hbtn==2)
        {
            Application.Quit();
        }
    
    }
}
