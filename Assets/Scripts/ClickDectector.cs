using UnityEngine;

public class ClickDectector : MonoBehaviour
{
    // This script is what detects when an object has been clicked. 
    private GlimmerManager glimmerManager;

    private void Start()
    {
        glimmerManager = FindAnyObjectByType<GlimmerManager>();
    }


    private void OnMouseDown() //This how it knows when clicked
    {
        glimmerManager.GainByClick();
        Debug.Log("Clicked");
    }
}
