using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTracker : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Buildings;


    private void Start()
    {
        foreach (var building in Buildings)
        {
              
                GameObject children1 = building.transform.GetChild(0).gameObject;
                //GameObject children2 = building.transform.GetChild(1).gameObject;
                children1.SetActive(true);
                //children2.SetActive(true);
                Debug.Log("Awake called");
                //Debug.Log(children1+"children1");
        }
    }

    public void NegativeImpact()
    {
        foreach (var building in Buildings)
        {
            GameObject children1 = building.transform.GetChild(0).gameObject;
            GameObject children2 = building.transform.GetChild(1).gameObject;
            children1.SetActive(false);
            children2.SetActive(true);
            Debug.Log("NegativeImpact called");

        }
    }
    public void PositiveImpact()
    {
        foreach (var building in Buildings)
        {
            GameObject children1 = building.transform.GetChild(0).gameObject;
            GameObject children2 = building.transform.GetChild(1).gameObject;
            children2.SetActive(false);
            children1.SetActive(true);
            Debug.Log("PositiveImpact called");
            
              
        }
    }
}
