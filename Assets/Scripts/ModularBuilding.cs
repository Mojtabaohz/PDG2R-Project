using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModularBuilding : MonoBehaviour
{
    public GameObject HealthyBuilding;

    public GameObject DamagedBuildibg;

    public bool damaged = false;
    
    // Update is called once per frame
    void Update()
    {
        UpdatePrefab();
    }

    public void UpdatePrefab()
    {
        if (damaged)
        {
            HealthyBuilding.SetActive(false);
            DamagedBuildibg.SetActive(true);
        }
        else
        {
            HealthyBuilding.SetActive(true);
            DamagedBuildibg.SetActive(false);
        }
    }

    public void DamageBuilding()
    {
        damaged = true;
    }

    public void HealBuilding()
    {
        damaged = false;
    }
}
