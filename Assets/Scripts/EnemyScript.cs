using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public double enemyHealth = 10f;

    public float enemySpeed = 5f;

    public EnemyClickDetect enemyClickDetect;

    private void Start()
    {
        enemyClickDetect = FindAnyObjectByType<EnemyClickDetect>();
    }


    private void OnMouseDown() //This how it knows when clicked
    {
        enemyClickDetect.EnemyClicked();
        Debug.Log("Clicked");
    }

    public void EnemyTakeDamage()
    {

    }
}
