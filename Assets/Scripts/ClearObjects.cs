using System;
using UnityEngine;

public class ClearObjects : MonoBehaviour
{
    [SerializeField] private string destroyableTag = "Destroyable";

    void Start()
    {
        UIButtonHandler.OnUIClearButtonClicked += ClearOnButtonClicked;
    }

    private void ClearOnButtonClicked()
	{
        // Log
        var allObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var obj in allObjects)
        {
            if (obj.name.Contains("Wooden"))
            {
                Debug.Log(obj.name + " | Tag: " + obj.tag);
            }
        }

        // Get all object with the "Destroyable" tag and destroy them
        GameObject[] gos = GameObject.FindGameObjectsWithTag(destroyableTag);
        Debug.Log(gos.Length);
        foreach(GameObject go in gos)
		{
            Destroy(go);
		}
	}
}
