using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;
using ResourceManager = UnityTemplateProjects.ResourceManager;

public class OptionManager : MonoBehaviour
{
    public Button option;
    [SerializeField] public int HappinessOutcome;
    private int value = 10;
    [SerializeField] public int EnergyOutcome;

    [SerializeField] public int MoneyOutcome;

    [SerializeField] private Text TextBox;

    private ResourceManager resources;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = option.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick(){
        Debug.Log ("You have chosen the option!");
        resources = GameObject.FindGameObjectWithTag("Resourcemanager").GetComponent<ResourceManager>();
        resources.setSlider(gameObject);
        //GameObject.FindWithTag("Resourcemanager").GetComponent<ResourceManager>().setSlider(HappinessOutcome,ResourceManager.FindObjectOfType<Slider>());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
