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
    // Start is called before the first frame update
    void Start()
    {
        Button btn = option.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick(){
        Debug.Log ("You have chosen the option!");
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
