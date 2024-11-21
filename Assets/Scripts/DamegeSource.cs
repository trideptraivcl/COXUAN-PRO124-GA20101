using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DamegeSource : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<EnemyAI>())
        {
            
        }
    }
}
