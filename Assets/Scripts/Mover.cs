using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rBody;
    public float MaxSpeed;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();

        var x = Random.Range(0, MaxSpeed);
        var z = Random.Range(0, MaxSpeed);

        rBody.velocity = new Vector3(x, 0, z);
    }
}
