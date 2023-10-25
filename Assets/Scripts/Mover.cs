using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rBody;
    public float MaxSpeed;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();

        var x = Random.Range(-MaxSpeed, MaxSpeed);
        var z = Random.Range(-MaxSpeed, MaxSpeed);

        rBody.velocity = new Vector3(x, 0, z);
    }

}
