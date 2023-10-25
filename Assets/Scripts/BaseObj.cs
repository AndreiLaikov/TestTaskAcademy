using UnityEngine;

public class BaseObj : MonoBehaviour
{
    protected string tagName = "Border";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagName))
        {
            ApplyChange();
        }
    }

    protected virtual void ApplyChange()
    {
        throw new System.NotImplementedException();
    }

}
