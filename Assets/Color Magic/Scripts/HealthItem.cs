using UnityEngine;

public class HealthItem : MonoBehaviour
{
    [SerializeField] private float healthRestoreAmount = 50f; // 恢复的生命值
    [SerializeField] private AudioClip pickupSound; // 道具拾取音效

    private void Start()
    {
        // 确保道具的SpriteRenderer始终在最上层显示
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sortingOrder = 100; // 设置Order in Layer为较高值
        }
    }

    private void OnMouseDown()
    {
        // 获取场景中玩家对象的Health脚本
        Health playerHealth = FindObjectOfType<Health>();
        if (playerHealth != null)
        {
            playerHealth.ApplyDamage(-healthRestoreAmount); // 负值表示恢复生命值
        }

        if (pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        }

        Destroy(gameObject); // 删除道具
    }
}
