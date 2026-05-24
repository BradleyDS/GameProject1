using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GlimShopScript : MonoBehaviour
{
    public float glimAmount = 100f;
    public float passiveIncrease = 0f;
    public float upgradeCost = 100f;
    private Button thisButton;


    private void Start()
    {
        thisButton = GetComponent<Button>();
    }

    private void Update()
    {
        GainGlimmer();
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
