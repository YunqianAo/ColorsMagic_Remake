using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject healthItemPrefab; // ���ߵ�Ԥ����
    [SerializeField] private Vector2 spawnAreaMin; // ���ɷ�Χ�����½�
    [SerializeField] private Vector2 spawnAreaMax; // ���ɷ�Χ�����Ͻ�
    [SerializeField] private float spawnInterval = 5f; // ���ɼ�����룩
    [SerializeField] private float healthRestoreAmount = 50f; // �ָ�������ֵ

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

