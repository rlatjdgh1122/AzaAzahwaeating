using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    [SerializeField] GameObject panel = null;
   public void StartBotton()
    {
        SceneManager.LoadScene(1);
    }
    public void Explanation()
    {
        panel.SetActive(true);
    }
    public void ExplanationClose()
    {
        panel.SetActive(false);
    }
    public void IntroBotton()
    {
        SceneManager.LoadScene(0);
    }
    public void exit()
    {
        Application.Quit();
    }
}
