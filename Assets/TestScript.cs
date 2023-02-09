using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EVRA.Inputs;

public class TestScript : MonoBehaviour
{

    public GameObject testObject = null;

    public void ToggleObject(InputEventDataPackage package) {
        if (testObject != null) testObject.SetActive(!testObject.activeInHierarchy);
    }

    public void ToggleObject() {
        if (testObject != null) testObject.SetActive(!testObject.activeInHierarchy);
    }
}
