using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlimShopScript : MonoBehaviour
{
    public double upgradeCost = 100f;
    private Button thisButton;
    public TMP_Text upgradeCostText;
    public GlimmerManager glimManScript;

    private void Start()
    {
        thisButton = GetComponent<Button>();
        glimManScript = FindAnyObjectByType<GlimmerManager>();
    }

    private void Update()
    {
        GainGlimmer();
        upgradeCostText.text = upgradeCost.ToString();

        if (glimManScript.glimAmount < upgradeCost)
        {
            thisButton.interactable = false;
               
        }
        else if (glimManScript.glimAmount > upgradeCost)
        {
            thisButton.interactable = true;
        }
     

    }

    public void ButtonUpgrade()
    {
        glimManScript.glimAmount -= upgradeCost;
        glimManScript.passiveIncrease += 10f * 0.5f;
        upgradeCost += 50f * 0.3f;
    }

    public void GainGlimmer()
    {
        glimManScript.glimAmount += glimManScript.passiveIncrease * Time.deltaTime;

    }

}
