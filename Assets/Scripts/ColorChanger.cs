using UnityEngine;

[RequireComponent (typeof (MeshRenderer))]
public class ColorChanger : BaseObj
{
    private Material material;

    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    protected override void ApplyChange()
    {
        ChangeMaterial();
    }

    private void ChangeMaterial()
    {
        Color color = Random.ColorHSV();
        material.color = color;
    }
}
