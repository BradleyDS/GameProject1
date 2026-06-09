using TMPro;
using UnityEngine;

public class GlimmerManager : MonoBehaviour
{
    public double glimAmount = 100f;
    public TMP_Text glimAmountText;
    public double passiveIncrease = 0f;
    public TMP_Text passiveIncreasetext;
    public double clickPower = 1f;


    // Update is called once per frame
    void Update()
    {
        glimAmountText.text = glimAmount.ToString();
        passiveIncreasetext.text = passiveIncrease.ToString() + "/s";
    }
    public void GainByClick()
    {
        glimAmount += clickPower;
    }
}
