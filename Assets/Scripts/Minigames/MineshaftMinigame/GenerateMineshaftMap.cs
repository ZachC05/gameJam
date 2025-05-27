using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateMineshaftMap : MonoBehaviour
{
    [Header("Points")]
    public float startPointX;
    public float startPointY;


    [Header("Max rows and colums (Ex: 3 = 9 squares, 4 = 16 squares")]
    public float maxGeneration;


    [Header("SpecificPeices")]
    public GameObject cornerLD;
    public GameObject cornerDR;
    public GameObject cornerRT;
    public GameObject cornerTL;
    public GameObject straightTD;
    public GameObject straightRL;

    public GameObject[] MineshaftPeices;

    [Header("Connectors")]
    public GameObject TopConnector;
    public GameObject BottomConnector;
    public GameObject RightConnector;
    public GameObject LeftConnector;



    private List<GameObject> selectableRails = new List<GameObject>();

    public bool start;
    // Start is called before the first frame update
    void Start()
    {




        
        if (start)
        {
            selectableRails.Clear();
            selectableRails.Add(cornerLD);
            selectableRails.Add(straightRL);
            for (int i = 0; i < maxGeneration; i++)
            {
                for (int j = 0; j < maxGeneration; j++)
                {
                    GenerateRail();
                    startPointX += 100;
                }
                startPointY -= 100;
                startPointX = -100;

            }
        }
    }

    public void GenerateRail()
    {
        int range = Random.Range(0, selectableRails.Count);
        GameObject newPeice = Instantiate(selectableRails[range], transform.position, Quaternion.identity);
        newPeice.transform.SetParent(transform, false);
        newPeice.transform.localPosition = new Vector3(startPointX, startPointY, 0);

        Debug.Log(newPeice.transform.localPosition);
    }

    void ChooseRail()
    {
        if(TopConnector != null && startPointY != 100)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
