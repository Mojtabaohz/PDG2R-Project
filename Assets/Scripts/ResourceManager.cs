using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTemplateProjects
{
    public class ResourceManager : MonoBehaviour
    {
        [SerializeField] private Slider happiness = null;
        //private int currentHappiness;
        [SerializeField] private Slider energy;
        //private int currentEnergy;
        [SerializeField] private int money;
        [SerializeField] private Text moneyText;
        [SerializeField] private Text currentYearText;
        private int currentYear;
        [SerializeField] private Slider yearsSlider;
        
        private int negativeEnergy = 40;
        private int negativHappiness;

        private int positiveEnergy;
        private int positiveHappiness;

        
        void Start()
        {
            happiness.maxValue = 100;
            happiness.value = 50;
            energy.maxValue = 100;
            energy.value = 50;
            money = 75;
            currentYear = 2021;
            currentYearText.text = currentYear.ToString();
            yearsSlider.maxValue = 50;
            yearsSlider.value = 0;
            moneyText.text = money.ToString();
        }
        

        void CheckResources()
        {
            Debug.Log("before if" +negativeEnergy);
            if (energy.GetComponent<Slider>().value < negativeEnergy)
            {
                FindObjectOfType<CityTracker>().NegativeImpact();
                
            }
            else if (energy.GetComponent<Slider>().value >= negativeEnergy)
            {
                FindObjectOfType<CityTracker>().PositiveImpact();
            }
        }
        
        public void setSlider(GameObject option)
        {
            happiness.value += option.GetComponent<OptionManager>().HappinessOutcome;
            energy.value += option.GetComponent<OptionManager>().EnergyOutcome;
            money += option.GetComponent<OptionManager>().MoneyOutcome;
            moneyText.text = money.ToString();
            CheckResources();
        }

        public void YearProgress()
        {
            yearsSlider.value += 10;
            currentYear += 10;
            currentYearText.text = currentYear.ToString();
        }

        public void DelayCall()
        {
            
        }

        public void InvisUI()
        {
            
        }
    }
}