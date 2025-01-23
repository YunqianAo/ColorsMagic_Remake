using UnityEngine;

public class HealthItem : MonoBehaviour
{
    [SerializeField] private float healthRestoreAmount = 50f; // �ָ�������ֵ
    [SerializeField] private AudioClip pickupSound; // ����ʰȡ��Ч

    private void Start()
    {
        // ȷ�����ߵ�SpriteRendererʼ�������ϲ���ʾ
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sortingOrder = 100; // ����Order in LayerΪ�ϸ�ֵ
        }
    }

    private void OnMouseDown()
    {
        // ��ȡ��������Ҷ����Health�ű�
        Health playerHealth = FindObjectOfType<Health>();
        if (playerHealth != null)
        {
            playerHealth.ApplyDamage(-healthRestoreAmount); // ��ֵ��ʾ�ָ�����ֵ
        }

        if (pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        }

        Destroy(gameObject); // ɾ������
    }
}
