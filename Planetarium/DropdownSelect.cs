using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownSelect : MonoBehaviour
{
    [Header("celestialBodyInfo")]
    [SerializeField]
    private TMP_Dropdown timeDropdown;

    [Header("celestialBodyInfo")]
    [SerializeField]
    private List<CelestialBodyInfo> bodyInfoList;
    [SerializeField]
    private TMP_Dropdown bodySelect;
    [SerializeField]
    private GameObject bodyInfoField;
    [SerializeField]
    private TextMeshProUGUI bodyInfoText;
    [SerializeField]
    private bool showInfo;

    // |"UniversalValues" is a singleton

    public void ChangeTimeSpeedDropDown()
    {// change the time speed to the one selected
        switch (timeDropdown.value)
        {
            case 0:// no time
                UniversalValues.Values.timeStep = 0f;
                break;
            case 1:// 1 second
                UniversalValues.Values.timeStep = 1f / 24f / 60f / 60f;
                break;
            case 2:// 1 minute
                UniversalValues.Values.timeStep = 1f / 24f / 60f;
                break;
            case 3:// 1 hour
                UniversalValues.Values.timeStep = 1f / 24f;
                break;
            case 4:// 1 day
                UniversalValues.Values.timeStep = 1f;
                break;
            case 5:// 1 week
                UniversalValues.Values.timeStep = 1f * 7f;
                break;
            case 6:// 1 month
                UniversalValues.Values.timeStep = 1f * 30f;
                break;
            case 7:// 1 year
                UniversalValues.Values.timeStep = 1f * 365.25f;
                break;
        }
    }

    public void SelectBodyInfo()
    {// show info about the selected body
        if (showInfo == false)
        {
            showInfo = true;
        }

        bodyInfoText.text = bodyInfoList[bodySelect.value].bodyInfo;

        bodyInfoField.SetActive(showInfo);
    }

    public void CloseBodyInfoField()
    {
        bodyInfoField.SetActive(false);
    }
}
