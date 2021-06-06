using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;
using ResourceManager = UnityTemplateProjects.ResourceManager;

public class OptionManager : MonoBehaviour
{
    public Button option;
    public int HappinessOutcome;
    public int EnergyOutcome;
    public int PollutionOutcome;
    public int MoneyOutcome;
    
    //[SerializeField] private Text TextBox;
    

    private ResourceManager resources;
    private ButtonEvents buttonevents;
    private rdmButton button;
    
    void Awake()
    {
        resources = GameObject.FindGameObjectWithTag("Resourcemanager").GetComponent<ResourceManager>();
        buttonevents = GameObject.FindGameObjectWithTag("Resourcemanager").GetComponent<ButtonEvents>();
        button = GameObject.FindObjectOfType<rdmButton>().GetComponent<rdmButton>();
        Button btn = option.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick); 
    }

    void TaskOnClick(){
        //Debug.Log ("You have chosen the option!");
        resources.CallDelay();
        resources.setSlider(gameObject);
        buttonevents.CheckButtonClicked(gameObject.name);
        button.DestroyButtons();
        button.PrepareButtons();
        resources.YearProgress();
        //GameObject.FindWithTag("Resourcemanager").GetComponent<ResourceManager>().setSlider(HappinessOutcome,ResourceManager.FindObjectOfType<Slider>());
    }

    
    
    
}
