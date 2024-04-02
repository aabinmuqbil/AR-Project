using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceObjectByName : MonoBehaviour
{
    public GameObject newObjectPrefab; // Assign the new object prefab in the inspector

    public void ActivateReplaceObject()
    {
        ReplaceObject("Fox(Clone)");
    }

    void ReplaceObject(string objectNameToReplace)
    {
        // Find the object by name
        GameObject objectToReplace = GameObject.Find(objectNameToReplace);
        if (objectToReplace != null)
        {
            // Instantiate the new object at the old object's position and rotation
            GameObject newObject = Instantiate(newObjectPrefab, objectToReplace.transform.position, objectToReplace.transform.rotation);
            newObjectPrefab.transform.position = objectToReplace.transform.position;
            // Optionally, to maintain the same parent
            //if (objectToReplace.transform.parent != null)
           // {
           //     newObject.transform.SetParent(objectToReplace.transform.parent);
           // }

            // Destroy the old object
            Destroy(objectToReplace);
        }
        else
        {
            Debug.LogWarning($"Object named '{objectNameToReplace}' not found.");
        }
    }
}
