using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCreatorMover : MonoBehaviour
{
    private float _width;
    private bool _show = false;

    private void Start()
    {
        _width = GetComponent<RectTransform>().sizeDelta.x;
    }

    public void ShowCreator()
    {
        if (_show == false)
        {
            transform.Translate(-_width, 0, 0);
            _show = true;
        }
        else
        {
            transform.Translate(_width, 0, 0);
            _show = false;
        }
    }
}
