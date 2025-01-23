using UnityEngine;

public class ColorBlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab; // ɫ��Ԥ����
    public int blockCount = 6; // ÿ�غ����ɵ�ɫ������
    public Transform spawnArea; // ��������ĸ�����

    public void GenerateBlocks()
    {
        // ���֮ǰ��ɫ��
        foreach (Transform child in spawnArea)
        {
            Destroy(child.gameObject);
        }

        // �������ɫ��
        for (int i = 0; i < blockCount; i++)
        {
            GameObject newBlock = Instantiate(blockPrefab, spawnArea);
            newBlock.transform.localPosition = GetRandomPosition();
        }
    }

    private Vector3 GetRandomPosition()
    {
        // �������λ�ã����Ը��ݾ������������Χ��
        float x = Random.Range(-200f, 200f);
        float y = Random.Range(-200f, 200f);
        return new Vector3(x, y, 0);
    }
}
