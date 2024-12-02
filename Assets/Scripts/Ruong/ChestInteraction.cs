using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public Sprite openChest; // Sprite khi rương mở
    private SpriteRenderer spriteRenderer;
    private bool isOpen = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.F))
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        if (!isOpen) // Nếu rương chưa mở
        {
            spriteRenderer.sprite = openChest; // Đổi sprite sang trạng thái mở
            isOpen = true; // Đánh dấu rương đã mở
            Debug.Log("Chest opened!");
            // Thêm logic khác (nếu cần) như trao phần thưởng
        }
        else
        {
            Debug.Log("Chest is already open.");
        }
    }
}
