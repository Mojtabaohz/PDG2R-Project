using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HappinessManager : MonoBehaviour
{
    [SerializeField]
    private Slider happiness = null;

    public int happinessValue { get; private set; }

    private GameObject activeIcon;

    public GameObject[] iconList;
    // Start is called before the first frame update
    


    private void CalculateHappiness(float i)
            {
                if (i>60)
                {
                    happinessValue = i < 85 ? 1 : 0;
                }
                else
                {
                    happinessValue = i < 25 ? 3 : 2;
                }
            }
    public void CheckHappiness()
    {
        CalculateHappiness(happiness.value);
        switch (happinessValue)
        {
            case 0: 
                ChangeHappinessIcon(0);
                break;
            case 1:
                ChangeHappinessIcon(1);
                break;
            case 2:
                ChangeHappinessIcon(2);
                break;
            case 3:
                ChangeHappinessIcon(3);
                break;
            default:
                ChangeHappinessIcon(2);
                break;
        }
    }
    
            private void ChangeHappinessIcon(int i)
            {
                if (activeIcon)
                {
                    activeIcon.SetActive(false);
                }
                
                activeIcon = iconList[i];
                activeIcon.SetActive(true);
            }
    // Update is called once per frame
    void Update()
    {
        
    }
}
