using TMPro; // Thêm namespace TextMeshPro
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int coin = 0; // Số lượng coin
    public TextMeshProUGUI text; // Text UI để hiển thị số lượng coin

    public void AddCoin()
    {
        coin++; // Tăng số lượng coin
        if (text != null)
        {
            text.text = coin.ToString(); // Cập nhật nội dung của Text UI
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI chưa được gán trong Inspector!");
        }
    }
}
