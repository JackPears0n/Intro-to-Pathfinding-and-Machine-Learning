using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Vector3 firstPos;
    public Vector3 secondPos;


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(secondPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToPos()
    {

    }
}
