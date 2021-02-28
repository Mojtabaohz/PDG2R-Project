using UnityEngine;
using UnityEngine.UI;

namespace UnityTemplateProjects
{
    public class ResourceManager : MonoBehaviour
    {
        [SerializeField] private Slider happiness;
        private int currentHappiness;
        [SerializeField] private Slider energy;
        [SerializeField] private Text Money;
        
        void Start()
        {
            happiness.maxValue = 100;
            energy.maxValue = 100;
        }
        public void increaseSlider(int amount,Slider slider)
        {
            slider.value += amount;
        }

        public void setSlider(int amount,Slider slider)
        {
            
        }
        
        
        
        
        
        
    }
}