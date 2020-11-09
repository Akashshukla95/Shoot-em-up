using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int yPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while(enemyCount < 100)
        {
            xPos = Random.Range(-12, 9);
            yPos = Random.Range(-19, 4);
            Instantiate(theEnemy, new Vector3(xPos,yPos,0),Quaternion.identity);
            yield return new WaitForSeconds(4);
            enemyCount += 1;
        }
    }
}
