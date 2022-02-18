using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triagle : MonoBehaviour
{
    private void OnMouseUp()
    {
        GameController.SelectedObgect(gameObject);
    }
}
