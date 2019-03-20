using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Slider timeSpeedSlider = null;

    [SerializeField]
    private Text timeSpeedSliderLabel = null;

    [SerializeField]
    private Slider noiseScaleSlider = null;

    [SerializeField]
    private Text noiseScaleSliderLabel = null;

    [SerializeField]
    private Material deformationMaterial = null;

    // Update is called once per frame
    void Update()
    {
        if(deformationMaterial != null){
            // time speed 
            deformationMaterial.SetFloat("_TimeSpeed", timeSpeedSlider.value);
            timeSpeedSliderLabel.text = $"Time Speed: {timeSpeedSlider.value}";

            // noise scale
            deformationMaterial.SetFloat("_NoiseScale", noiseScaleSlider.value);
            noiseScaleSliderLabel.text = $"Noise Scale: {noiseScaleSlider.value}";
        }        
    }
}
