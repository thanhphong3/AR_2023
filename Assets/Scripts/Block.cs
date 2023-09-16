using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public enum eBlockState
    {
        IDLE,
        HOLD,
        SNAP,
    }
    public eBlockState BlockState;
    [SerializeField] List<Transform> SnapPoints;
    [SerializeField] float distanceSnap;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
