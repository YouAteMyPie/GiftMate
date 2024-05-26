using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button profilerViewButton;
    public Button storeViewButton;
    public Button calendarViewButton;

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(Instance == null) instance = GameObject.FindObjectOfType<GameManager>();
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameObject.name = "New Game Manager";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Awake()
    {
        if(GameObject.Find("New Game Manager"))
        {
            Destroy(gameObject);
        }
    }
}
