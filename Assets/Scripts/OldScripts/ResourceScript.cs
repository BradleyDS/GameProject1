using UnityEngine;
using UnityEngine.EventSystems;

public class ResourceScript : MonoBehaviour
{
    //This script handles passive glimmer income and glimmer income when clicked (Decrease isnt done yet that will be later)
    public float glimmerNum = 0f;
    public float passiveIncrease = 0f;
    public float glimmerDecrease = 0f;
    public float clickIncrease = 0f;



    // Update is called once per frame
    void Update()
    {
        //GainGlimmer();
        //print(glimmerNum);
    }
    public void GainByClick()
    {
        glimmerNum += clickIncrease;
    }
    public void GainGlimmer()
    {
        glimmerNum += passiveIncrease * Time.deltaTime;

    }
    public void LoseGLimmer()
    {
        glimmerNum -= glimmerDecrease = 0f;

    }
}
