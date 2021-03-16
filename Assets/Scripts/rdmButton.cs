using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;
using ResourceManager = UnityTemplateProjects.ResourceManager;

public class rdmButton : MonoBehaviour
{
    public List<GameObject> energyButtons;
    public List<GameObject> happinessButtons;
    public List<GameObject> moneyButtons;

    public GameObject canvas;
    public int active;

    public Button start;
    public Button random;
    public Button end;

    private GameObject EB;
    private GameObject HB;
    private GameObject MB;

    void Start()
    {
        Button starty = start.GetComponent<Button>();
        starty.onClick.AddListener(clickStart);

        Button randomy = random.GetComponent<Button>();
        randomy.onClick.AddListener(clickRandom);

        Button endy = end.GetComponent<Button>();
        endy.onClick.AddListener(clickEnd);
    }

    void Update()
    {

    }

    void clickStart()
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

        Debug.Log(erdm);
        Debug.Log(hrdm);
        Debug.Log(mrdm);

    }

    void clickRandom()
    {
        Destroy(EB);
        Destroy(MB);
        Destroy(HB);

        int erdm = Random.Range(0, energyButtons.Count);
        int hrdm = Random.Range(0, happinessButtons.Count);
        int mrdm = Random.Range(0, moneyButtons.Count);

        EB = Instantiate(energyButtons[erdm]) as GameObject;
        HB = Instantiate(happinessButtons[hrdm]) as GameObject;
        MB = Instantiate(moneyButtons[mrdm]) as GameObject;

        EB.transform.SetParent(canvas.transform, false);
        HB.transform.SetParent(canvas.transform, false);
        MB.transform.SetParent(canvas.transform, false);

        Debug.Log(erdm);
        Debug.Log(hrdm);
        Debug.Log(mrdm);
    }

    void clickEnd()
    {
        Destroy(EB);
        Destroy(MB);
        Destroy(HB);
    }
}
