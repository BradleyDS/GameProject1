using UnityEngine;

public class ClickDectector : MonoBehaviour
{
    // This script is what detects when an object has been clicked. This script and ResourceScript have to be on the same object to work
    private ResourceScript resourceScript;

    private void Start()
    {
        resourceScript = GetComponent<ResourceScript>(); //references ResourceScript
    }


    private void OnMouseDown() //This how it knows when clicked
    {
        resourceScript.GainByClick(); 
    }
}
