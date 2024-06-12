using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    public GameObject CurrentPins;
    public GameObject Prefab;
    private Vector3 position;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        position = CurrentPins.transform.position;
        rotation = CurrentPins.transform.rotation;
    }

    public void ResetFunction()
    {
        Destroy(CurrentPins);
        CurrentPins = Instantiate(Prefab, position, rotation);
    }
}
