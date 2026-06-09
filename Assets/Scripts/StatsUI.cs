using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statsMeshText;
    [SerializeField] private GameObject speedUpArrowObject;
    [SerializeField] private GameObject speedDownArrowObject;
    [SerializeField] private GameObject speedLeftArrowObject;
    [SerializeField] private GameObject speedRightArrowObject;
    [SerializeField] private Image fuelImage;

    private void Update()
    {
        UpdateStatsMeshText();
    }
    private void UpdateStatsMeshText()
    {
        speedUpArrowObject.SetActive(Lander.Instance.GetSpeedY() >= 0);
        speedDownArrowObject.SetActive(Lander.Instance.GetSpeedY() < 0);
        speedLeftArrowObject.SetActive(Lander.Instance.GetSpeedX() < 0);
        speedRightArrowObject.SetActive(Lander.Instance.GetSpeedX() >= 0);

        fuelImage.fillAmount = Lander.Instance.GetFuelAmountNormalize();

        statsMeshText.text =
            GameManager.instance.GetLevelNumber() + "\n" +
            GameManager.instance.GetScore() + "\n" +
            Mathf.Round(GameManager.instance.GetTime()) + "\n" +
            Mathf.Abs(Mathf.Round(Lander.Instance.GetSpeedX() * 10)) + "\n" +
            Mathf.Abs(Mathf.Round(Lander.Instance.GetSpeedY() * 10));
    }

}