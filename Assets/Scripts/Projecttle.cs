using UnityEngine;

public class Projecttile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 22f;

    private void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }
}
