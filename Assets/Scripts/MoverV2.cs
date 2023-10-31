using UnityEngine;

public class MoverV2 : MonoBehaviour
{
    protected string tagName = "Border";

    public float Speed;
    public Vector3 direction;

    private void Start()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float z = Random.Range(-1.0f, 1.0f);

        direction = new Vector3(x, 0, z);

        Rotate();
    }
    
    private void Rotate()
    {
        transform.rotation = Quaternion.FromToRotation(transform.forward, direction);
    }

    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagName))
        {
            
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.forward, out hit);

            var angle = Vector3.Reflect(transform.forward,hit.normal);
            transform.rotation = Quaternion.FromToRotation(angle, transform.forward);
        }
    }


}
