using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCreater : MonoBehaviour
{      
    public GameObject Panel;

    private int _show = 0;

    public void FixedUpdate()
    {
    }

    public void ShowCreator()
    {
        if (_show == 0)
        {
            Panel.transform.Translate(-200, 0, 0);
            _show++;
        }
        else
        {
            Panel.transform.Translate(200, 0, 0);
            _show--;
        }
    }
}
