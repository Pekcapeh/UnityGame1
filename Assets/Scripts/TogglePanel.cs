using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class TogglePanel : MonoBehaviour
{
    private float _width;
    private bool _shown = false;

    private void Start()
    {
        _width = GetComponent<RectTransform>().sizeDelta.x;
    }

    public void ShowCreator()
    {
        if (_shown == false)
        {
            transform.Translate(-_width, 0, 0);
            _shown = true;
        }
        else
        {
            transform.Translate(_width, 0, 0);
            _shown = false;
        }
    }
}
