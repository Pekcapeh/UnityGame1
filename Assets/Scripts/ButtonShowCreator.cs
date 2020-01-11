using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonShowCreator : MonoBehaviour
{      
    [SerializeField] private PanelCreator _toggle;
       
    public void TogglePanel()
    {
        _toggle.ShowCreator();
    }
}
