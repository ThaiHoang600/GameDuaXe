using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private Animator anim;

     void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Map1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Map2");

    }
    
    public void Maps()
    {
        anim.SetTrigger("Play");
    }

    public void Shopp()
    {
        SceneManager.LoadScene("Shop");
    }
}
