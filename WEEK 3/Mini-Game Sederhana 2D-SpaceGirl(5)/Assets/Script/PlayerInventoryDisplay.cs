using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] starPlaceholders;
    public Sprite iconLove;
    public Sprite iconStar;
    public void OnChangeStarTotal(int starTotal)
    {
        for (int i = 0; i < starPlaceholders.Length; ++i)
        {
            if (i < starTotal)
                starPlaceholders[i].sprite = iconStar;
            else
                starPlaceholders[i].sprite = iconLove;
        }
    }
}