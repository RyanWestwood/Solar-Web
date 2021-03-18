using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public GameObject mutedImage;
    public GameObject unmutedImage;

    public Slider slider;

	public void Start()
	{
		slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
		slider.value = PlayerPrefs.GetInt(slider.name);
	}

	public void ValueChangeCheck()
	{
		if(slider.value > 0.01)
        {
			mutedImage.SetActive(false);
			unmutedImage.SetActive(true);
        }
        else
        {
			mutedImage.SetActive(true);
			unmutedImage.SetActive(false);
		}
		PlayerPrefs.SetInt(slider.name, (int)slider.value);
		PlayerPrefs.Save();
	}
}
