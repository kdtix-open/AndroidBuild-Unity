using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ApplicationInfo : MonoBehaviour
{
    private TextMeshProUGUI tmpUIComponent;  // Reference to the Canvas UI Text component

    // Init
    private void Awake()
    {
        // Set up the reference.
        tmpUIComponent = GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Fetch the current Application version for desplay
        Debug.Log($"Application Version: {Application.version}");
        tmpUIComponent.SetText($"Android Build {Application.version}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
