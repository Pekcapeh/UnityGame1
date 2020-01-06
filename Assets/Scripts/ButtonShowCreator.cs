using UnityEngine;

public class ButtonShowCreator : MonoBehaviour
{      
    public GameObject Panel;

    private bool _show = false;    

    public void ShowCreator()
    {
        if (_show == false)
        {
            Panel.transform.Translate(-200, 0, 0);
            _show = true;
        }
        else
        {
            Panel.transform.Translate(200, 0, 0);
            _show = false;
        }
    }
}
