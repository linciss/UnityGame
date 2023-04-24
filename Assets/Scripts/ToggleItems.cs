using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleItems : MonoBehaviour {

	// Use this for initialization

	public GameObject[] hatArr;
    public GameObject[] headArr;
    public GameObject[] shirtArr;
    public GameObject[] pantArr;
    public GameObject[] shoeArr;

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


}
