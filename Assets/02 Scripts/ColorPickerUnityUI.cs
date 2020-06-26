using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPickerUnityUI : MonoBehaviour
{
    public bool circular;
    public Color value = Color.white;
    public RectTransform thumb;
    public Image colorPalette;
    public float scrollSpeed = 1200.0f;


    public void OnPress(Vector3 pointerPos)
    {
        UpdateThumbPosition(pointerPos, true);
    }

    public void OnDrag(Vector3 pointerPos)
    {
        UpdateThumbPosition(pointerPos, false);
    }

    private Color GetColor()
    {
        Vector2 SpectrumXY = new Vector2(colorPalette.GetComponent<RectTransform>().rect.width, colorPalette.GetComponent<RectTransform>().rect.height);
        Texture2D texture = colorPalette.mainTexture as Texture2D;
        Vector2 position;

        if (circular)
        {
            position = new Vector2((thumb.localPosition.x + SpectrumXY.x * 0.5f) / SpectrumXY.x, (thumb.localPosition.y + SpectrumXY.y * 0.5f) / SpectrumXY.y);
        }
        else
        {
            position = new Vector2((thumb.localPosition.x + SpectrumXY.x * 0.5f) / SpectrumXY.x, (thumb.localPosition.y + SpectrumXY.y * 0.5f) / SpectrumXY.y);
        }

        Color SelectedColor = texture.GetPixelBilinear(position.x, position.y);
        SelectedColor.a = 1;
        return SelectedColor;
    }

    private void UpdateThumbPosition(Vector3 pointerPos, bool isSecect)
    {
        if (circular && colorPalette.GetComponent<CircleCollider2D>())
        {
            if (thumb.localPosition != pointerPos)
            {
                Vector3 newThumb = new Vector3(pointerPos.x * scrollSpeed, pointerPos.y * scrollSpeed, pointerPos.z);
                thumb.localPosition = Vector3.ClampMagnitude(newThumb, colorPalette.mainTexture.width * 0.5f);
                if (isSecect)
                {
                    value = GetColor();
                }
            }
        }
        else if (colorPalette.GetComponent<BoxCollider>())
        {
            if (thumb.localPosition != pointerPos)
            {
                Vector3 newThumb = new Vector3(pointerPos.x * scrollSpeed, pointerPos.y * scrollSpeed, pointerPos.z);
                thumb.localPosition = Vector3.ClampMagnitude(newThumb, colorPalette.mainTexture.width * 0.5f); ;
                if (isSecect)
                {
                    value = GetColor();
                }
            }
        }
    }
   
}
