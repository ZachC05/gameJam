using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RailsConnector : MonoBehaviour
{

    [SerializeField] bool isStart, isEnd;

    [Header("Mineshaft Pieces")]
    public Image[] MineshaftPeices;


    [Header("Connectors")]
    public GameObject TopConnector;
    public GameObject BottomConnector;
    public GameObject RightConnector;
    public GameObject LeftConnector;

    public Vector3 CubeSize;
    public float sphereSize;

    // Start is called before the first frame update
    void Start()
    {
        if (isStart)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    



    private void OnDrawGizmos()
    {
        if(TopConnector != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(TopConnector.transform.position, sphereSize);


        }

        if(BottomConnector != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(BottomConnector.transform.position, sphereSize);



        }

        if(RightConnector != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(RightConnector.transform.position, sphereSize);

        }

        if(LeftConnector != null)
        {

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(LeftConnector.transform.position, sphereSize);
        }

    }
}
