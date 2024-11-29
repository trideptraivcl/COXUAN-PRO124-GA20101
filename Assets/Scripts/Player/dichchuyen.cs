using UnityEngine;

public class DichChuyen : MonoBehaviour
{
    [SerializeField] private GameObject Cong; // Reference to the portal-like object

    private void Update()
    {
        // Only move when Cong is assigned
        if (Cong != null)
        {
            Transform targetPosition = Cong.GetComponent<dadichchuyen>().GetDiemDichChuyenDen();
            if (targetPosition != null)
            {
                transform.position = targetPosition.position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the "dadichchuyen" tag
        if (collision.CompareTag("dadichchuyen"))
        {
            Cong = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Clear Cong when exiting the trigger
        if (collision.CompareTag("dadichchuyen"))
        {
            Cong = null;
        }
    }
}
