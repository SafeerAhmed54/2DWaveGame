using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefeb;
    [SerializeField] private int enemyCount;
    [SerializeField] private Transform spawnTopLeft, spawnTopRight, spawnBottomLeft, spawnBottomRight;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = SelectRandomPosition();
        Debug.Log(spawnPosition);
    }

    private Vector3 SelectRandomPosition()
    {
        Transform selectedTransform = null;
        int randomValue = Random.Range(0, 4);
        SpawnPointTypes spawnPoint = (SpawnPointTypes)randomValue;
        switch (spawnPoint)
        {
            case SpawnPointTypes.TopLeft:
                selectedTransform = spawnTopLeft;
                break;
            case SpawnPointTypes.TopRight:
                selectedTransform = spawnTopRight;
                break;
            case SpawnPointTypes.BottomLeft:
                selectedTransform = spawnBottomLeft;
                break;
            case SpawnPointTypes.BottomRight:
                selectedTransform = spawnBottomLeft;
                break;
            default:
                Debug.Log("Check Again");
                break;
        }
        return Vector3.zero;
    }

    public enum SpawnPointTypes
    {
        TopLeft = 0,
        TopRight = 1,
        BottomLeft = 2,
        BottomRight = 3
    }
}
