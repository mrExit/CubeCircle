using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coube : MonoBehaviour
{
    [SerializeField] [Range(1, 30)] int _scale = 10;
    [SerializeField] bool _isCircle;
    [SerializeField] Sprite _cube;
    [SerializeField] Sprite _circle;

    
    private void OnValidate()
    {
        initializationObgect();
    }
    private void initializationObgect()
    {
        GetComponent<SpriteRenderer>().sprite = _isCircle ? _circle : _cube;
        tag = _isCircle ? "Circle" : "Cube";

        if (_isCircle)
        {
            name = "Circle";
            GetComponent<SpriteRenderer>().sortingOrder = 0;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = true;
        }
        else
        {
            name = "Cube";
            GetComponent<SpriteRenderer>().sortingOrder = 1;
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<CircleCollider2D>().enabled = false;
        }
        transform.localScale = new Vector3(_scale,_scale)/10;
    }
    private void OnMouseUp()
    {
        GameController.SelectedObgect(gameObject);
    }
}
