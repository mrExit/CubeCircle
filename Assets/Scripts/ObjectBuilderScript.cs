
using UnityEngine;

public class ObjectBuilderScript : MonoBehaviour
{

    [SerializeField] GameObject _object;
    [SerializeField] GameObject _triangle;

    public bool IsExtension;
    public void BuildObject()
    {
        Instantiate(_object);
    }
    public void BuildTriangle()
    {
        Instantiate(_triangle);
    }
    
}
