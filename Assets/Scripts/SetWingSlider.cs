using UnityEngine;
using UnityEngine.UI;

public class SetWingSlider : MonoBehaviour
{
    public Slider L_WingSlider;
    public Slider R_WingSlider;
    public Slider TailSlider;
    public void SetValueLeftWing(float newValue)
    {
        L_WingSlider.value = newValue;
    }
    public void SetValueRightWing(float newValue)
    {
        R_WingSlider.value = newValue;
    }
    public void SetValueTail(float newValue)
    {
        TailSlider.value = newValue;
    }
}
