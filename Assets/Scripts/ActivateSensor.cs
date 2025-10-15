using UnityEngine;

public class ActivateSensor : MonoBehaviour
{
    public ParticleSystem particles;
    public KeyCode activationKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(activationKey))
        {
            if (particles != null)
            {
                particles.Play();
            }
        }
    }
}


