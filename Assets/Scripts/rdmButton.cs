using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using ResourceManager = UnityTemplateProjects.ResourceManager;

public class rdmButton : MonoBehaviour
{
    public List<GameObject> energyButtons;
    public List<GameObject> happinessButtons;
    public List<GameObject> moneyButtons;

    public GameObject canvas;
    public int active;

    //public Button start;
    //public Button random;
    //public Button end;

    private GameObject EB;
    private GameObject HB;
    private GameObject MB;

    public void Start()
    {
        PrepareButtons();
    }

    void Update()
    {

    }

    public void PrepareButtons()
    {
        int erdm = Random.Range(0, energyButtons.Count);
        int hrdm = Random.Range(0, happinessButtons.Count);
        int mrdm = Random.Range(0, moneyButtons.Count);

        EB = Instantiate(energyButtons[erdm]) as GameObject;
        HB = Instantiate(happinessButtons[hrdm]) as GameObject;
        MB = Instantiate(moneyButtons[mrdm]) as GameObject;

        EB.transform.SetParent(canvas.transform, false);
        HB.transform.SetParent(canvas.transform, false);
        MB.transform.SetParent(canvas.transform, false);

        //Debug.Log(erdm);
        //Debug.Log(hrdm);
        //Debug.Log(mrdm);

    }

    void clickRandom()
    {
        Destroy(EB);
        Destroy(MB);
        Destroy(HB);

        int erdm = Random.Range(0, energyButtons.Count);
        int hrdm = Random.Range(0, happinessButtons.Count);
        int mrdm = Random.Range(0, moneyButtons.Count);

        EB = Instantiate(energyButtons[erdm]) ;
        HB = Instantiate(happinessButtons[hrdm]) ;
        MB = Instantiate(moneyButtons[mrdm]) ;

        EB.transform.SetParent(canvas.transform, false);
        HB.transform.SetParent(canvas.transform, false);
        MB.transform.SetParent(canvas.transform, false);

        Debug.Log(erdm);
        Debug.Log(hrdm);
        Debug.Log(mrdm);
    }

    public void DestroyButtons()
    {
        Destroy(EB);
        Destroy(MB);
        Destroy(HB);
    }
}
