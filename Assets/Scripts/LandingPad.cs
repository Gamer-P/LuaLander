using UnityEngine;

public class LandingPad : MonoBehaviour {
    [SerializeField] private float landingPadMultiplier;

    public float GetLandingPadMultiplier()
    {
        return landingPadMultiplier;
    }
}
