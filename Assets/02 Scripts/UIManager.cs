using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum Selection
    {
        BRUSHES,
        TOOLS,
        SETTINGS
    }

    Selection[] SelectionPool = { Selection.BRUSHES, Selection.TOOLS, Selection.SETTINGS };

    public static Selection currentSelection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
