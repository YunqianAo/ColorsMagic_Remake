using UnityEngine;

public class ColorBlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab; // 色块预制体
    public int blockCount = 6; // 每回合生成的色块数量
    public Transform spawnArea; // 生成区域的父对象

    public void GenerateBlocks()
    {
        // 清空之前的色块
        foreach (Transform child in spawnArea)
        {
            Destroy(child.gameObject);
        }

        // 随机生成色块
        for (int i = 0; i < blockCount; i++)
        {
            GameObject newBlock = Instantiate(blockPrefab, spawnArea);
            newBlock.transform.localPosition = GetRandomPosition();
        }
    }

    private Vector3 GetRandomPosition()
    {
        // 生成随机位置（可以根据具体需求调整范围）
        float x = Random.Range(-200f, 200f);
        float y = Random.Range(-200f, 200f);
        return new Vector3(x, y, 0);
    }
}
