using TMPro;
using UnityEngine;

public class GlimmerManager : MonoBehaviour
{
    public double glimAmount = 100f;
    public TMP_Text glimAmountText;
    public double passiveIncrease = 0f;
    public TMP_Text passiveIncreasetext;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        glimAmountText.text = glimAmount.ToString();
        passiveIncreasetext.text = passiveIncrease.ToString() + "/s";
    }
}
