using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();

    void Awake() 
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }
   
    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
    }

    void DisplayCoordinates()
    {
        Vector3 unityGridSize = UnityEditor.EditorSnapSettings.move;
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / unityGridSize.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / unityGridSize.z);

        label.text = $"{coordinates.x},{coordinates.y}";
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
