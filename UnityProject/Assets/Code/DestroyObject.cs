using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField, Header("Destroytime"), Range(0, 3)]
    private float destroyTime = 0.5f;

    private void Awake()
    {
        Destroy(gameObject, destroyTime);
    }

    private void OnBecameVisible()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
