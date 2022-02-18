using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectBuilderScript))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ObjectBuilderScript myScript = (ObjectBuilderScript)target;
        if (GUILayout.Button("Build Object"))
        {
            myScript.BuildObject();
        }
        if (myScript.IsExtension)
        {
            if (GUILayout.Button("Build Triangle"))
            {
                myScript.BuildTriangle();
            }
        }
        else
        {
            if (GameObject.FindWithTag("Triangle"))
                DestroyImmediate(GameObject.FindWithTag("Triangle"));
        }

    }
}

