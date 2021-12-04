using System;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    


    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;


        result = summandA + summandB;

        Debug.Log(result);
        txtResult.text = string.Format("{0}", result);
        return result;
    }


    void Start()
    {
      

    }

    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;


        Debug.Log("Methode GetValues wird ausgeführt:" + CheckAddition(int.Parse(termA), int.Parse(termB)));
    }
    
    void Update()
    {
        
        
    }

    

}
