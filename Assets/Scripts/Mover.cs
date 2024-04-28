using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition = new Vector3 (-2.5f, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3 (2.5f, 0, 0);
    [SerializeField] private int _stepsCount = 10;



    private void Start()
    {
        
    }
}
