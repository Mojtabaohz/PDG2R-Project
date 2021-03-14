using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rdmButton : MonoBehaviour
{
    public List<GameObject> energyButtons;
    public List<GameObject> happinessButtons;
    public List<GameObject> moneyButtons;
    public GameObject canvas;
    public int active;


    void Start()
    {
        int erdm = Random.Range(0, energyButtons.Count);
        int hrdm = Random.Range(0, happinessButtons.Count);
        int mrdm = Random.Range(0, moneyButtons.Count);

        GameObject EB = Instantiate(energyButtons[erdm]) as GameObject;
        GameObject HB = Instantiate(happinessButtons[hrdm]) as GameObject;
        GameObject MB = Instantiate(moneyButtons[mrdm]) as GameObject;

        EB.transform.SetParent(canvas.transform, false);
        HB.transform.SetParent(canvas.transform, false);
        MB.transform.SetParent(canvas.transform, false);

        Debug.Log(erdm);
        Debug.Log(hrdm);
        Debug.Log(mrdm);

        EB.SetActive(false);
        HB.SetActive(false);
        MB.SetActive(false);

    }

    void Update()
    {

    }
}
