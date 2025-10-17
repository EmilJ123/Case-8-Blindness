using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject targetObject;
    public float activeDuration = 5f;
    public string triggeringTag = "Player";
    private bool isActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggeringTag) && !isActive)
        {
            if (targetObject != null)
            {
                targetObject.SetActive(true);
                isActive = true;
                Invoke(nameof(DeactivateTarget), activeDuration);
            }
        }
    }

    void DeactivateTarget()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);
            isActive = false;
        }
    }
}



