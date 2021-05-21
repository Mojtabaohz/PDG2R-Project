using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour
{
    public GameObject solarPanels0;
    public GameObject solarPanels1;
    public GameObject solarPanels2;
    public GameObject solarPanels3;

    public GameObject windTurbines;

    private int panelsBuilt;
    private bool turbinesBuilt;

    void Awake()
    {
        panelsBuilt = 0;
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
        // if(!panelsBuilt)
        // {
        //     Instantiate(solarPanels, new Vector3(0, 0, 0), Quaternion.identity);
        //     panelsBuilt = true;
        // }
        // else
        // {
        //     //could change this to accomodate gradual increase of panels when same option has been clicked multiple times
        //     Debug.Log("Solar panels are already built");
        // }

        switch(panelsBuilt)
        {
            case 0:
                Instantiate(solarPanels0, new Vector3(0, 0, 0), Quaternion.identity);
                panelsBuilt++;
                break;
            case 1:
                Instantiate(solarPanels1, new Vector3(0, 0, 0), Quaternion.identity);
                panelsBuilt++;
                break;
            case 2:
                Instantiate(solarPanels2, new Vector3(0, 0, 0), Quaternion.identity);
                panelsBuilt++;
                break;                
            case 3:
                Instantiate(solarPanels3, new Vector3(0, 0, 0), Quaternion.identity);
                panelsBuilt++;
                break;
            default:
                Debug.Log("Solar panels are maxed out");
                break;

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
