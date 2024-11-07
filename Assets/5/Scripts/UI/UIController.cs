using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using System.Linq;

public class UIController : MonoBehaviour
{
    private TextMeshProUGUI _citizenList;

    void Start()
    {
        
        Transform textTransform = transform.Find("Panel/CitizenList");

        if (textTransform != null)
        {
            _citizenList = textTransform.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            Debug.LogWarning("path not found");
        }
    }
    private void Update()
    {
        UpdateCitizenListText();
    }

    public void UpdateCitizenListText()
    {
        if (_citizenList != null)
        {
            var list = DataManager.Instance.CitizenList;
            string allCitizenTitles = string.Join("\n", list.Select(citizen => $"{citizen.Name} {citizen.Title} - ID: {citizen.ID}"));

            _citizenList.text = @$"Citizen List:\n{allCitizenTitles}";
        }
    }

    public void CityPlannerButtonPressed()
    {
        DataManager.Instance.CitizenList.Add(new CityPlanner());
    }

    public void ConstructionWorkerButtonPressed()
    {
        DataManager.Instance.CitizenList.Add(new ConstructionWorker());
    }
}
