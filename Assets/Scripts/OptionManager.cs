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
    
    [SerializeField] public int EnergyOutcome;

    [SerializeField] public int MoneyOutcome;

    [SerializeField] private Text TextBox;

    private ResourceManager resources;

    private rdmButton button;
    // Start is called before the first frame update
    void Awake()
    {
        resources = GameObject.FindGameObjectWithTag("Resourcemanager").GetComponent<ResourceManager>();
        button = GameObject.FindObjectOfType<rdmButton>().GetComponent<rdmButton>();
        Button btn = option.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick(){
        Debug.Log ("You have chosen the option!");
        resources.setSlider(gameObject);
        button.DestroyButtons();
        button.PrepareButtons();
        //GameObject.FindWithTag("Resourcemanager").GetComponent<ResourceManager>().setSlider(HappinessOutcome,ResourceManager.FindObjectOfType<Slider>());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
