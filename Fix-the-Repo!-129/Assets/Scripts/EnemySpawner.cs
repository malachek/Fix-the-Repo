using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] EnemyBehavior enemyPrefab;

    [SerializeField] ScoreBoard scoreBoard;

    private List<EnemyBehavior> spawnedEnemies = new List<EnemyBehavior>();

    public void NewRound()
    {
        KillEnemies();
        SpawnEnemies(scoreBoard.score / 5 + 1);
    }

    private void KillEnemies()
    {
        foreach (EnemyBehavior enemyBehavior in spawnedEnemies)
        {
            Destroy(enemyBehavior.gameObject);
        }

        //reset list
        spawnedEnemies = new List<EnemyBehavior>();
    }

    public void SpawnEnemies(int amountToSpawn)
    {
        for (int i = 0;  i < amountToSpawn; i++)
        {
            spawnedEnemies.Add(Instantiate(enemyPrefab, new Vector3(Random.Range(0, 6), Random.Range(-4, 4), 0), Quaternion.identity));
        }
    }
}
