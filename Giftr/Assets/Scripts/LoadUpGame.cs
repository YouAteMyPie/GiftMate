using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUpGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadWrongScene()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadVictoryScene()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadUpQuestion1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadUpQuestion2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadUpQuestion3()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadUpQuestion4()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadUpQuestion5()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadUpQuestion6()
    {
        SceneManager.LoadScene(6);
    }

}
