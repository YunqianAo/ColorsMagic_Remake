using UnityEngine;
using UnityEngine.UI;  

public class ColorDisplay : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Image colorDisplay;

    void Start()
    {
        redSlider.minValue = 0;
        redSlider.maxValue = 255;

        greenSlider.minValue = 0;
        greenSlider.maxValue = 255;

        blueSlider.minValue = 0;
        blueSlider.maxValue = 255;

        UpdateColor();
        
        redSlider.onValueChanged.AddListener(delegate { UpdateColor(); });
        greenSlider.onValueChanged.AddListener(delegate { UpdateColor(); });
        blueSlider.onValueChanged.AddListener(delegate { UpdateColor(); });
    }

    void UpdateColor()
    {
        Color color = new Color(
            redSlider.value / 255f,   
            greenSlider.value / 255f, 
            blueSlider.value / 255f   
        );

        colorDisplay.color = color;
    }
}
