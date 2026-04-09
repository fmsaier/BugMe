using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UnlockedCollectable : MonoBehaviour
{
    public Image Image;
    public GameObject Panel;
    public TMPro.TextMeshProUGUI Text;

    public void Render(CollectableData collectable)
    {
        Image.sprite = collectable.sprite;
        Text.text = "找到了 " + collectable.ChineseName + "！";
        Panel.SetActive(true);
    }

    public void RenderAlreadyUnlocked(CollectableData collectable)
    {
        Image.sprite = collectable.sprite;
        Text.text = collectable.ChineseName + "!";
        Panel.SetActive(true);
    }
}