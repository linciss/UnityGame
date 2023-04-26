using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleItems : MonoBehaviour {

	// Use this for initialization

	public GameObject[] hatArr;
    public GameObject[] headArr;
    public GameObject[] shirtArr;
    public GameObject[] pantArr;
    public GameObject[] shoeArr;
    public GameObject humanImage, widthSlider, heightSlider;
    public Sprite[] humanArr;
    float height =1f, width =1f;



    public void hatImage(bool status) 
	{
		for (int i = 0; i < hatArr.Length; i++)
		{
			hatArr[i].SetActive(status);
		}
	}
    public void headImage(bool status)
    {
        for (int i = 0; i < headArr.Length; i++)
        {
            headArr[i].SetActive(status);
        }
    }
    public void shirtImage(bool status)
    {
        for (int i = 0; i < shirtArr.Length; i++)
        {
            shirtArr[i].SetActive(status);
        }
    }
    public void pantsImage(bool status)
    {
        for (int i = 0; i < pantArr.Length; i++)
        {
            pantArr[i].SetActive(status);
        }
    }
    public void shoeImage(bool status)
    {
        for (int i = 0; i < shoeArr.Length; i++)
        {
            shoeArr[i].SetActive(status);
        }
    }
   
    public void dropDown(int index)
    {
        if (index == 0)
        {
            humanImage.GetComponent<Image>().sprite = humanArr[index];
            return;
        }
        humanImage.GetComponent<Image>().sprite = humanArr[index];
    }

    public void changeWidth()
    {
        width = widthSlider.GetComponent<Slider>().value;
        humanImage.transform.localScale = new Vector2(1f * width,height);
    }

    public void changeHeight()
    {
        height = heightSlider.GetComponent<Slider>().value;
        humanImage.transform.localScale = new Vector2(width, 1f * height);
    }


}
