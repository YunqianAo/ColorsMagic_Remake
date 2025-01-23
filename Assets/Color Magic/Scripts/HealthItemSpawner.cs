using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject healthItemPrefab; // 道具的预制体
    [SerializeField] private Vector2 spawnAreaMin; // 生成范围的左下角
    [SerializeField] private Vector2 spawnAreaMax; // 生成范围的右上角
    [SerializeField] private float spawnInterval = 5f; // 生成间隔（秒）
    [SerializeField] private float healthRestoreAmount = 50f; // 恢复的生命值

    private void Start()
    {
        StartCoroutine(SpawnHealthItems());
    }

    private IEnumerator SpawnHealthItems()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnHealthItem();
        }
    }

    private void SpawnHealthItem()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(healthItemPrefab, randomPosition, Quaternion.identity);
    }
}

