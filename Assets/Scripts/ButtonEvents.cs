using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{
    public GameObject solarPanels;
    public GameObject windTurbines;

    private bool panelsBuilt;
    private bool turbinesBuilt;

    void Awake()
    {
        panelsBuilt = false;
        turbinesBuilt = false;
    }

    //Checks name of object to which this script is attached
    public void CheckButtonClicked(string name)
    {
        switch(name)
        {
            case "Build solar panels(Clone)":
                BuildSolarPanels();
                break;
            case "Build wind turbines(Clone)":
                BuildWindTurbines();
                break;
            default: 
                Debug.Log("Default Button Check");
                break;
        }
    }

    //Instantiate solarpanels prefab when function is called
    void BuildSolarPanels()
    {
        if(!panelsBuilt)
        {
            Instantiate(solarPanels, new Vector3(0, 0, 0), Quaternion.identity);
            panelsBuilt = true;
        }
        else
        {
            //could change this to accomodate gradual increase of panels when same option has been clicked multiple times
            Debug.Log("Solar panels are already built");
        }
    }

    void BuildWindTurbines()
    {
        if(!turbinesBuilt)
        {
            Instantiate(windTurbines, new Vector3(0, 0, 0), Quaternion.identity);
            turbinesBuilt = true;
        }
        else
        {
            Debug.Log("Wind turbines are already built");
        }
    }
}
