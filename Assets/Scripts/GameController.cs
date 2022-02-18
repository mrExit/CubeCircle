using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static private GameObject _selectedObject;   

    static public void SelectedObgect(GameObject selectedObgect)
    {
        
        if (_selectedObject != null)
        {
           
            if (_selectedObject.CompareTag("Cube") && selectedObgect.CompareTag("Circle"))
            {                
                CompareObjects(_selectedObject, selectedObgect);                
            }
            if (_selectedObject.CompareTag("Triangle") && selectedObgect.CompareTag("Cube"))
            {               
                ReductionCube(_selectedObject, selectedObgect);
            }
        }
        if (selectedObgect.CompareTag("Cube"))
        {         
            _selectedObject = selectedObgect;
        }
        else if (selectedObgect.CompareTag("Triangle"))
        {
            _selectedObject = selectedObgect;
        }
    }

    private static void ReductionCube(GameObject triangle, GameObject cube)
    {
        
        Destroy(triangle);
        cube.transform.localScale = new Vector3 (cube.transform.localScale.x-0.1f, cube.transform.localScale.y-0.1f);
    }

    private static void CompareObjects(GameObject cube, GameObject circle)
    {
        if (cube.transform.lossyScale.x<=circle.transform.lossyScale.x)
        {
            cube.transform.position = circle.transform.position;
            cube.GetComponent<BoxCollider2D>().enabled = false;            
            _selectedObject = circle;
        }
    }
}
