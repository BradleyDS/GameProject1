using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlimShopScript : MonoBehaviour
{
    public double glimAmount = 100f;
    public double passiveIncrease = 0f;
    public double upgradeCost = 100f;
    private Button thisButton;
    public TMP_Text upgradeCostText;
    public TMP_Text glimAmountText;

    private void Start()
    {
        thisButton = GetComponent<Button>();
        
    }

    private void Update()
    {
        GainGlimmer();
        upgradeCostText.text = upgradeCost.ToString();
        glimAmountText.text = glimAmount.ToString();
        //print(glimAmount);

        if (glimAmount < upgradeCost)
        {
            thisButton.interactable = false;
            
        }
        else if (glimAmount > upgradeCost)
        {
            thisButton.interactable = true;
        }
     

    }

    public void ButtonUpgrade()
    {
        glimAmount -= upgradeCost;
        passiveIncrease += 10f;
        upgradeCost += 50f;
    }

    public void GainGlimmer()
    {
        glimAmount += passiveIncrease * Time.deltaTime;

    }

}
