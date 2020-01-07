using UnityEngine;

public class ButtonShowCreator : MonoBehaviour
{      
    public GameObject Panel;

    private float _width;
    private bool _show = false;

    private void Start()
    {
        _width = Panel.GetComponent<RectTransform>().sizeDelta.x;
    }

    public void ShowCreator()
    {
        if (_show == false)
        {
            Panel.transform.Translate(- _width, 0, 0);
            _show = true;
        }
        else
        {
            Panel.transform.Translate(_width, 0, 0);
            _show = false;
        }
    }
}
