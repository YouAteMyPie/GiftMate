using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    [SerializeField] private RawImage background;
    [SerializeField] private float xscroll;
    [SerializeField] private float yscroll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(xscroll, yscroll) * Time.deltaTime, background.uvRect.size);   
    }
}
