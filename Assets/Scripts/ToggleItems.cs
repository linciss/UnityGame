
using UnityEngine;
using UnityEngine.UI;

public class ToggleItems : MonoBehaviour {

	// Use this for initialization

	public GameObject[] h1HatArr;
    public GameObject[] h1ShirtArr;
    public GameObject[] h1PantArr;
    public GameObject[] h1ShoeArr;
    public GameObject[] h2HatArr;
    public GameObject[] h2ShirtArr;
    public GameObject[] h2PantArr;
    public GameObject[] h2ShoeArr;
    public GameObject[] toggles;
    public GameObject humanImage, widthSlider, heightSlider;
    public Sprite[] humanArr;
    float height =1f, width =1f;
    int humanIndex = 0;



    public void hatImage(bool status) 
	{
        if (humanIndex == 0)
        {
            for (int i = 0; i < h1HatArr.Length; i++)
            {
                h1HatArr[i].SetActive(status);
            }
        }
        else {
            for (int i = 0; i < h1ShirtArr.Length; i++)
            {
                h2HatArr[i].SetActive(status);
            }
        }
        
    }
  

 
  
    public void shirtImage(bool status)
    {
        if (humanIndex == 0)
        {
            for (int i = 0; i < h1ShirtArr.Length; i++)
            {
                h1ShirtArr[i].SetActive(status);
            }
        }
        else
        {
            for (int i = 0; i < h1ShirtArr.Length; i++)
            {
                h2ShirtArr[i].SetActive(status);
            }
        }

    }
    public void pantsImage(bool status)
    {

        if (humanIndex == 0)
        {
            for (int i = 0; i < h1PantArr.Length; i++)
            {
                h1PantArr[i].SetActive(status);
            }
        }
        else
        {
            for (int i = 0; i < h1ShirtArr.Length; i++)
            {
                h2PantArr[i].SetActive(status);
            }
        }

    }
    public void shoeImage(bool status)
    {
        if (humanIndex == 0)
        {
            for (int i = 0; i < h1ShoeArr.Length; i++)
            {
                h1ShoeArr[i].SetActive(status);
            }
        }
        else
        {
            for (int i = 0; i < h1ShirtArr.Length; i++)
            {
                h2ShoeArr[i].SetActive(status);
            }
        }
        
    }
   
    public void dropDown(int index)
    {
        humanIndex = index;
        if (index == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                h2HatArr[i].SetActive(false);
                h2ShirtArr[i].SetActive(false);
                h2PantArr[i].SetActive(false);
                h2ShoeArr[i].SetActive(false);
            }
            for (int i = 0; i < toggles.Length; i++)
            {
                toggles[i].GetComponent<Toggle>().isOn = false;
            }
            humanImage.GetComponent<Image>().sprite = humanArr[index];
            return;
        }
        else {
            for (int i = 0; i < 3; i++)
            {
                h1HatArr[i].SetActive(false);
                h1ShirtArr[i].SetActive(false);
                h1PantArr[i].SetActive(false);
                h1ShoeArr[i].SetActive(false);
            }

            for (int i = 0; i < toggles.Length; i++)
            {
                toggles[i].GetComponent<Toggle>().isOn = false;
            }
            humanImage.GetComponent<Image>().sprite = humanArr[index];
            return;
        }
        
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

    public void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            //h1
            h1HatArr[i].transform.localScale = new Vector2(width, height);
            h1ShirtArr[i].transform.localScale = new Vector2(width, height);
            h1PantArr[i].transform.localScale = new Vector2(width, height);
            h1ShoeArr[i].transform.localScale = new Vector2(width, height);

            //h2
            h2HatArr[i].transform.localScale = new Vector2(width, height);
            h2ShirtArr[i].transform.localScale = new Vector2(width, height);
            h2PantArr[i].transform.localScale = new Vector2(width, height);
            h2ShoeArr[i].transform.localScale = new Vector2(width, height);

        }
      

    }
}
