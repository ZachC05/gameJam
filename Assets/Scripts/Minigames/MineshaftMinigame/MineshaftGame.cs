using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineshaftGame : MonoBehaviour
{
    [Header("Mineshaft Pieces")]


    public List<GameObject> activeMineshaftPeices;

    public GameObject StartingPoint;
    public GameObject EndingPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void GenerateMineshaftMap()
    {

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.blue;
        Gizmos.DrawCube(StartingPoint.transform.position, new Vector3(100f, 100f, 1f));

        Gizmos.color = Color.red;
        Gizmos.DrawCube(EndingPoint.transform.position, new Vector3(100f, 100f, 1f));
    }
}
