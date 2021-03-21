using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTemplateProjects
{
    public class ResourceManager : MonoBehaviour
    {
        [SerializeField] private Slider happiness;
        private int currentHappiness;
        [SerializeField] private Slider energy;
        private int currentEnergy;
        [SerializeField] private Text Money;


        
        void Start()
        {
            happiness.maxValue = 100;
            energy.maxValue = 100;
        }

        private void Update()
        {
            CheckResources();
        }

        void CheckResources()
        {
            if (energy.GetComponent<Slider>().value < 10)
            {
                FindObjectOfType<CityTracker>().NegativeImpact();
            }
            else
            {
                FindObjectOfType<CityTracker>().PositiveImpact();
            }
        }
        
        public void setSlider(GameObject option)
        {
            happiness.value += option.GetComponent<OptionManager>().HappinessOutcome;
            energy.value += option.GetComponent<OptionManager>().EnergyOutcome;
        }
    }
}