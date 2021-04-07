using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sreButton : MonoBehaviour
{

    public GameObject startButton;
    public GameObject randomizeButton;
    public GameObject endButton;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        GameObject SB = Instantiate(startButton) as GameObject;
        GameObject RB = Instantiate(randomizeButton) as GameObject;
        GameObject EnB = Instantiate(endButton) as GameObject;

        EnB.transform.SetParent(canvas.transform, false);
        SB.transform.SetParent(canvas.transform, false);
        RB.transform.SetParent(canvas.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
