using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Rotatingvector;
    private void Update() { 
        transform.Rotate(Rotatingvector * Time.deltaTime);
}
}
