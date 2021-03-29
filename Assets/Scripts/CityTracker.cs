using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class CityTracker : MonoBehaviour
{
    [SerializeField]
    //private GameObject[] Buildings;
    private List<GameObject> Buildings = new List<GameObject>();
    [SerializeField]
    private List<GameObject> DamagedBuildings = new List<GameObject>();
    [SerializeField]
    private List<GameObject> HealthyBuildings = new List<GameObject>();


    private void Start()
    {
        foreach (GameObject building in Buildings)
        {
            //Debug.Log(building);
            building.GetComponent<ModularBuilding>().UpdatePrefab();
            HealthyBuildings.Add(building);
        }
    }

    public void NegativeImpact()
    {
        NegativeImpact(RandomBuildings(BuildingCounts(),HealthyBuildings));
    }
    public void NegativeImpact(List<GameObject> buildings)
    {
        if (HealthyBuildings != null)
        {
            foreach (GameObject building in buildings)
            {
                if (!building.GetComponent<ModularBuilding>().damaged)
                {
                    building.GetComponent<ModularBuilding>().DamageBuilding();
                    DamagedBuildings.Add(building);
                    HealthyBuildings.Remove(building);
                }
            }
        }
    }

    
    
    public void PositiveImpact()
    {
        PositiveImpact(RandomBuildings(BuildingCounts(), DamagedBuildings));
    }
    public void PositiveImpact(List<GameObject> buildings)
    {
        if (DamagedBuildings != null)
        {
            foreach (var building in buildings)
            {
                if (building.GetComponent<ModularBuilding>().damaged)
                {
                    building.GetComponent<ModularBuilding>().HealBuilding();
                    DamagedBuildings.Remove(building);
                    HealthyBuildings.Add(building);
                }
            }
        }
    }



    private int BuildingCounts()
    {
        int currentCount = Buildings.Count;
        int result = (currentCount * 10 / 100)+1;
        return result;
    }
    public List<GameObject> RandomBuildings(int count,List<GameObject> target)
    {
        List<GameObject> randomItems = GetRandomItemsFromList<GameObject> (target, count);
        return randomItems;
    }
    public static List<T> GetRandomItemsFromList<T> (List<T> list, int number)
    {
        // this is the list we're going to remove picked items from
        List<T> tmpList = new List<T>(list);
        // this is the list we're going to move items to
        List<T> newList = new List<T>();
 
        // make sure tmpList isn't already empty
        while (newList.Count < number && tmpList.Count > 0)
        {
            int index = Random.Range(0, tmpList.Count);
            newList.Add(tmpList[index]);
            tmpList.RemoveAt(index);
        }
 
        return newList;
    }
    
}
