using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BaseObj[] prefabs;

    public int count;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instant();
        }
    }

    [ContextMenu("Create")]
    void Create()
    {
        for (int i = 0; i < count; i++)
        {
            Instant();
        }
    }

    private void Instant()
    {
        int index = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[index], transform.position, Quaternion.identity);
    }
}
