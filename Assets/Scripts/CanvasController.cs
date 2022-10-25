using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject rowWorkersPrefab;
    public GameObject panelParent;


    private static CanvasController _instance;

    public static CanvasController Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    // Start is called before the first frame update
    public void ChangeTexts(string aPos, string atotalEmploy, string aInitSala, string aAnnualIncre, string aSalaIncreassed)
    {
        var tempRowWorkers = Instantiate(rowWorkersPrefab, panelParent.transform);
        ChangeValuesToDisplay valuesToChangeComp;

        valuesToChangeComp = tempRowWorkers.GetComponent<ChangeValuesToDisplay>();
        valuesToChangeComp.ChangeTextsWorkerPos(aPos);
        valuesToChangeComp.ChangeTextsTotalEmployers(atotalEmploy);
        valuesToChangeComp.ChangeTextsInitialSalary(aInitSala);
        valuesToChangeComp.ChangeTextsAnnualIncrease(aAnnualIncre);
        valuesToChangeComp.ChangeTextsSalaryIncreased(aSalaIncreassed);
        
    }
}
