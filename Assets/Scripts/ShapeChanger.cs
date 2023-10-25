using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshCollider))]
public class ShapeChanger : BaseObj
{
    [SerializeField] private Mesh[] meshs;

    private MeshFilter meshFilter;
    private MeshCollider meshCollider;

    private int previousIndex = 0;
    private int currentIndex;

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshCollider = GetComponent<MeshCollider>();

        meshFilter.mesh = meshs[previousIndex];
        meshCollider.sharedMesh = meshs[previousIndex];
    }

    protected override void ApplyChange()
    {
        Randomize();
        ChangeShape();
    }

    void ChangeShape()
    {
        meshFilter.mesh = meshs[currentIndex];
        meshCollider.sharedMesh = meshs[currentIndex];

        previousIndex = currentIndex;
    }

    private void Randomize()
    {
        currentIndex  = Random.Range(0, meshs.Length);
        if(currentIndex == previousIndex)
        {
            Randomize();
        }
    }
}
