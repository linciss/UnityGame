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
    public GameObject humanImage;
    public Sprite[] humanArr;

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
    /*    public void Izkritosais(int indekss)
        {
            if (indekss == 0)
                mainigaisAttels.GetComponent<Image>().sprite
                    = atteluMasivs[0];

            else if (indekss == 1)
                mainigaisAttels.GetComponent<Image>().sprite
                    = atteluMasivs[1];

            else if (indekss == 2)
                mainigaisAttels.GetComponent<Image>().sprite
                    = atteluMasivs[2];
        }*/
    public void dropDown(int index)
    {
        if (index == 0)
        {
            humanImage.GetComponent<Image>().sprite = humanArr[index];
            return;
        }
        humanImage.GetComponent<Image>().sprite = humanArr[index];
    }


}
