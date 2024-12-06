using UnityEngine;

public class Coin : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
{
    // Kiểm tra nếu đối tượng va chạm là Player
    if (other.CompareTag("Player"))
    {
        // Lấy CoinManager từ đối tượng Player và gọi hàm addCoin()
        CoinManager coinManager = other.gameObject.GetComponent<CoinManager>();
        if (coinManager != null)
        {
            coinManager.AddCoin(); // Gọi hàm AddCoin trong CoinManager
        }
        else
        {
            Debug.LogWarning("CoinManager không được tìm thấy trên Player.");
        }

        // Hủy đối tượng Coin sau khi được nhặt
        Destroy(gameObject);
    }
}

}
