using UnityEngine;

public class SizeChanger : BaseObj
{
    [SerializeField]private float minSize;
    [SerializeField]private float maxSize;

    protected override void ApplyChange()
    {
        var newSize = Random.Range(minSize, maxSize);
        transform.localScale = Vector3.one * newSize;
    }
}
