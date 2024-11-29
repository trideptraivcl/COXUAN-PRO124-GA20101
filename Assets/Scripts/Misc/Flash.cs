using System.Collections;
using UnityEngine;

public class Flash : MonoBehaviour
{
    [SerializeReference] private Material whiteFlashMat;
    [SerializeReference] private float restoreDefaultMatTime = .2f;

    private Material defaultMat;
    private SpriteRenderer spriteRenderer;
    

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultMat = spriteRenderer.material;
    }

    public float GetRestoreMatTime()
    {
        return restoreDefaultMatTime;
    }

    public IEnumerator FlashRoutine()
    {
        spriteRenderer.material = whiteFlashMat;
        yield return new WaitForSeconds(restoreDefaultMatTime);
        spriteRenderer.material = defaultMat;
    }
}
