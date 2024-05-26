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

    public void LoadUpProfilerView()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadUpStoresView()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadUpCalendarView()
    {
        SceneManager.LoadScene(0);
    }

}
