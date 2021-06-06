using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityTemplateProjects
{
    public class ResourceManager : MonoBehaviour
    {
        [SerializeField] private Slider happiness = null;
        //private int currentHappiness;
        [SerializeField] private Slider energy;
        //private int currentEnergy;
        [SerializeField] private Slider pollution;
        [SerializeField] private int money;
        [SerializeField] private Text moneyText;

        [SerializeField] private int happinessOutcome;
        [SerializeField] private int energyOutcome;
        [SerializeField] private int pollutionOutcome;
        [SerializeField] private int moneyOutcome;
        
        [SerializeField] private Text happinessOutcomeText;
        [SerializeField] private Text energyOutcomeText;
        [SerializeField] private Text pollutionOutcomeText;
        [SerializeField] private Text moneyOutcomeText;
        
        
        [SerializeField] private Text currentYearText;
        private int currentYear;
        [SerializeField] private Slider yearsSlider;
        [SerializeField] public CanvasGroup optionsCanvas;
        [SerializeField] private GameObject endGamePanel;
        private bool gameEnded;

        
        
        private int negativeEnergy = 40;
        private int negativHappiness;

        private int positiveEnergy;
        private int positiveHappiness;

        
        void Start()
        {
            HideOutcome();
            gameEnded = false;
            endGamePanel.SetActive(false);
            happiness.maxValue = 100;
            happiness.value = 50;
            energy.maxValue = 100;
            energy.value = 50;
            pollution.maxValue = 100;
            pollution.value = 5;
            money = 75;
            currentYear = 2021;
            currentYearText.text = currentYear.ToString();
            yearsSlider.maxValue = 50;
            yearsSlider.value = 0;
            moneyText.text = money.ToString();
        }
        

        void CheckResources()
        {
            if (energy.GetComponent<Slider>().value < negativeEnergy)
            {
                FindObjectOfType<CityTracker>().NegativeImpact();
            }
            else if (energy.GetComponent<Slider>().value >= negativeEnergy)
            {
                FindObjectOfType<CityTracker>().PositiveImpact();
            }
        }

        private void SetOutcome(GameObject option)
        {
            happinessOutcome = option.GetComponent<OptionManager>().HappinessOutcome;
            energyOutcome = option.GetComponent<OptionManager>().EnergyOutcome;
            pollutionOutcome = option.GetComponent<OptionManager>().PollutionOutcome;
            moneyOutcome = option.GetComponent<OptionManager>().MoneyOutcome;
        }
        public void setSlider(GameObject option)
        {
            SetOutcome(option);
            happiness.value += happinessOutcome;
            energy.value += energyOutcome;
            pollution.value += pollutionOutcome;
            money += moneyOutcome;
            moneyText.text = money.ToString();
            SetOutcome();
            CheckResources();
        }

        public void YearProgress()
        {
            if (currentYear <= 2070)
            {
                yearsSlider.value += 10;
                currentYear += 10;
                currentYearText.text = currentYear.ToString();
            }
            else
            {
                EndGame();
            }
            
        }

        private IEnumerator DelayCall(float time)
        {
            yield return new WaitForSeconds(time);
            //Debug.Log("UIActivated");
            //TODO: Activate UI
            ActivateUI();
            //LeanTween.alphaCanvas(optionsCanvas, 1, 0.9f).setEase(LeanTweenType.easeInCirc);
        }

        private IEnumerator HideOutcomeDelay(float time)
        {
            yield return new WaitForSeconds(time);
            HideOutcome();
        }

        public void CallDelay()
        {
            //TODO: Deactivate UI
            optionsCanvas.blocksRaycasts = false;
            LeanTween.alphaCanvas(optionsCanvas, 0, 0.9f).setEase(LeanTweenType.easeOutCirc);
            StartCoroutine(DelayCall(4f));
        }

        public void ActivateUI()
        {
            //Debug.Log("UIActivated");
            if (!gameEnded)
            {
                optionsCanvas.blocksRaycasts = true;
            }
            LeanTween.alphaCanvas(optionsCanvas, 1, 0.9f).setEase(LeanTweenType.easeInCirc);
            
        }

        private void EndGame()
        {
            gameEnded = true;
            Debug.Log("UI Disabled");
            endGamePanel.SetActive(true);
            optionsCanvas.blocksRaycasts = false;
            StartCoroutine(ReloadScene());
        }

        private void HideOutcome()
        {
            happinessOutcomeText.gameObject.SetActive(false);
            energyOutcomeText.gameObject.SetActive(false);
            pollutionOutcomeText.gameObject.SetActive(false);
            moneyOutcomeText.gameObject.SetActive(false);
            
        }

        private void SetOutcome()
        {
            happinessOutcomeText.text = happinessOutcome.ToString();
            energyOutcomeText.text = happinessOutcome.ToString();
            pollutionOutcomeText.text = pollutionOutcome.ToString();
            moneyOutcomeText.text = moneyOutcome.ToString();
            ShowOutcome();
        }

        private void ShowOutcome()
        {
            happinessOutcomeText.gameObject.SetActive(true);
            happinessOutcomeText.GetComponent<TweenAnimate>().Tween();
            energyOutcomeText.gameObject.SetActive(true);
            energyOutcomeText.GetComponent<TweenAnimate>().Tween();
            pollutionOutcomeText.gameObject.SetActive(true);
            pollutionOutcomeText.GetComponent<TweenAnimate>().Tween();
            moneyOutcomeText.gameObject.SetActive(true);
            moneyOutcomeText.GetComponent<TweenAnimate>().Tween();
            StartCoroutine(HideOutcomeDelay(2f));
        }
        private IEnumerator ReloadScene()
        {
            yield return new WaitForSeconds(10f);
            Debug.Log("scene Reloaded");
            SceneManager.LoadScene("MelvinTest scene") ;
        }

    }
}