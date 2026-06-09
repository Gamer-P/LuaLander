using TMPro;
using UnityEngine;

public class LandingPadVisuals : MonoBehaviour
{
    [SerializeField] private TextMeshPro landerScoreMultiplier;

    private void Awake()
    {
        LandingPad landingPad = GetComponent<LandingPad>();
        landerScoreMultiplier.text = "x" + landingPad.GetLandingPadMultiplier();
    }
}
