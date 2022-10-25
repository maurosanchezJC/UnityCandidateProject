using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RunProgram : MonoBehaviour
{

    public WorkersCreator[] workersToCreate;
    [System.Serializable]
    public class WorkersCreator
    {
        public WorkPosition workpos;
        public int quantity;
    }

    public List<WorkPosition> totalWorkers = new List<WorkPosition>();

    private void Start()
    {
        CreateEmployers();
        IncremateSalaries();
        DisplaySalaries();
    }
    void IncremateSalaries()
    {
        for (int i = 0; i < totalWorkers.Count; i++)
        {
            totalWorkers[i].IncrementSalaryByPercentage();
        }
    }

    void CreateEmployers()
    {
        for (int i = 0; i < workersToCreate.Length; i++)
        {
            for (int j = 0; j < workersToCreate[i].quantity; j++)
            {
                totalWorkers.Add(workersToCreate[i].workpos);
            }
        }        
    }

    void DisplaySalaries()
    {
        WorkPosition prevWorker;
        GameObject go = new GameObject("PrevWorkerGO");
        prevWorker = go.AddComponent<WorkPosition>();


        for (int i = 0; i < totalWorkers.Count; i++)
        {
            if (prevWorker.GetType() != totalWorkers[i].GetType())
            {
                var totalElemtes = totalWorkers.Count(x => x.GetType() == totalWorkers[i].GetType());
                
                CanvasController.Instance.ChangeTexts(totalWorkers[i].GetType().ToString(),
                    totalElemtes.ToString(), 
                    totalWorkers[i].GetInitialSalary().ToString(), 
                    totalWorkers[i].GetIncrementPercentage().ToString(), 
                    totalWorkers[i].GetSalary().ToString());

               prevWorker = totalWorkers[i];
            }
        }
    }

}
