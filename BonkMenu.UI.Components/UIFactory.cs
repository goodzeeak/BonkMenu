using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UniverseLib;

namespace BonkMenu.UI.Components;

public static class UIFactory
{
	private static readonly Color ColorBgDark = new Color(0.1f, 0.1f, 0.12f, 1f);

	private static readonly Color ColorBgLighter = new Color(0.15f, 0.15f, 0.2f, 1f);

	private static readonly Color ColorAccent = new Color(0.2f, 0.8f, 1f, 1f);

	private static readonly Color ColorAccentDim = new Color(0.2f, 0.8f, 1f, 0.3f);

	private static readonly Color ColorTextMain = new Color(0.9f, 0.9f, 0.95f, 1f);

	private static readonly Color ColorTextDim = new Color(0.7f, 0.7f, 0.8f, 1f);

	public static void CreateSectionHeader(string text, GameObject parent)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Header_" + text);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 40f);
		VerticalLayoutGroup val3 = val.AddComponent<VerticalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val3).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val3).childControlHeight = true;
		((HorizontalOrVerticalLayoutGroup)val3).spacing = 4f;
		GameObject val4 = new GameObject("Text");
		val4.transform.SetParent(val.transform, false);
		Text val5 = val4.AddComponent<Text>();
		val5.text = text.ToUpper();
		val5.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		val5.fontSize = 15;
		val5.fontStyle = (FontStyle)1;
		((Graphic)val5).color = ColorAccent;
		val5.alignment = (TextAnchor)6;
		GameObject val6 = new GameObject("Line");
		val6.transform.SetParent(val.transform, false);
		Image val7 = val6.AddComponent<Image>();
		((Graphic)val7).color = ColorAccentDim;
		LayoutElement val8 = val6.AddComponent<LayoutElement>();
		val8.minHeight = 2f;
		val8.preferredHeight = 2f;
	}

	public static Button CreateButton(string text, Action onClick, GameObject parent)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Button_" + text);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 35f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = ColorBgLighter;
		Button val4 = val.AddComponent<Button>();
		((Selectable)val4).targetGraphic = (Graphic)(object)val3;
		((UnityEvent)val4.onClick).AddListener((UnityAction)onClick);
		ColorBlock colors = ((Selectable)val4).colors;
		colors.normalColor = ColorBgLighter;
		colors.highlightedColor = new Color(0.25f, 0.25f, 0.35f, 1f);
		colors.pressedColor = new Color(0.1f, 0.1f, 0.15f, 1f);
		colors.selectedColor = colors.normalColor;
		colors.colorMultiplier = 1f;
		colors.fadeDuration = 0.1f;
		RuntimeHelper.SetColorBlock((Selectable)(object)val4, colors);
		Outline val5 = val.AddComponent<Outline>();
		((Shadow)val5).effectColor = new Color(0f, 0f, 0f, 0.5f);
		((Shadow)val5).effectDistance = new Vector2(1f, -1f);
		GameObject val6 = new GameObject("Text");
		val6.transform.SetParent(val.transform, false);
		RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.anchorMin = Vector2.zero;
		val7.anchorMax = Vector2.one;
		val7.sizeDelta = Vector2.zero;
		Text val8 = val6.AddComponent<Text>();
		val8.text = text;
		val8.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		val8.fontSize = 14;
		val8.fontStyle = (FontStyle)0;
		((Graphic)val8).color = ColorTextMain;
		val8.alignment = (TextAnchor)4;
		return val4;
	}

	public static Text CreateLabel(string text, GameObject parent)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Label");
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 25f);
		Text val3 = val.AddComponent<Text>();
		val3.text = text;
		val3.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		val3.fontSize = 14;
		((Graphic)val3).color = ColorTextDim;
		val3.alignment = (TextAnchor)3;
		return val3;
	}

	public static void CreateSpacer(int height, GameObject parent)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Spacer");
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, (float)height);
	}

	public static void CreateCircularToggle(string label, bool initialValue, Action<bool> onChange, GameObject parent)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Toggle_" + label);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 35f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = ColorBgLighter;
		HorizontalLayoutGroup val4 = val.AddComponent<HorizontalLayoutGroup>();
		RectOffset val5 = new RectOffset();
		val5.left = 10;
		val5.right = 10;
		val5.top = 5;
		val5.bottom = 5;
		((LayoutGroup)val4).padding = val5;
		((HorizontalOrVerticalLayoutGroup)val4).spacing = 15f;
		((HorizontalOrVerticalLayoutGroup)val4).childControlWidth = false;
		((LayoutGroup)val4).childAlignment = (TextAnchor)3;
		GameObject val6 = new GameObject("Checkbox");
		val6.transform.SetParent(val.transform, false);
		RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.sizeDelta = new Vector2(24f, 24f);
		Image val8 = val6.AddComponent<Image>();
		((Graphic)val8).color = new Color(0.05f, 0.05f, 0.1f, 1f);
		Toggle val9 = val6.AddComponent<Toggle>();
		val9.isOn = initialValue;
		((Selectable)val9).targetGraphic = (Graphic)(object)val8;
		((UnityEvent<bool>)(object)val9.onValueChanged).AddListener((UnityAction<bool>)onChange);
		GameObject val10 = new GameObject("Checkmark");
		val10.transform.SetParent(val6.transform, false);
		RectTransform val11 = val10.AddComponent<RectTransform>();
		val11.anchorMin = Vector2.zero;
		val11.anchorMax = Vector2.one;
		val11.sizeDelta = new Vector2(-6f, -6f);
		Image val12 = val10.AddComponent<Image>();
		((Graphic)val12).color = ColorAccent;
		val9.graphic = (Graphic)(object)val12;
		GameObject val13 = new GameObject("Label");
		val13.transform.SetParent(val.transform, false);
		RectTransform val14 = val13.AddComponent<RectTransform>();
		val14.sizeDelta = new Vector2(300f, 25f);
		Text val15 = val13.AddComponent<Text>();
		val15.text = label;
		val15.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		val15.fontSize = 14;
		val15.fontStyle = (FontStyle)1;
		((Graphic)val15).color = ColorTextMain;
		val15.alignment = (TextAnchor)3;
	}

	public static void CreateSlider(string label, float min, float max, float defaultValue, Action<float> onChange, GameObject parent)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Slider_" + label);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 35f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = ColorBgLighter;
		HorizontalLayoutGroup val4 = val.AddComponent<HorizontalLayoutGroup>();
		RectOffset val5 = new RectOffset();
		val5.left = 10;
		val5.right = 10;
		val5.top = 5;
		val5.bottom = 5;
		((LayoutGroup)val4).padding = val5;
		((HorizontalOrVerticalLayoutGroup)val4).spacing = 15f;
		((HorizontalOrVerticalLayoutGroup)val4).childControlWidth = false;
		((LayoutGroup)val4).childAlignment = (TextAnchor)3;
		GameObject val6 = new GameObject("Label");
		val6.transform.SetParent(val.transform, false);
		RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.sizeDelta = new Vector2(140f, 25f);
		Text val8 = val6.AddComponent<Text>();
		val8.text = label;
		val8.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		val8.fontSize = 14;
		val8.fontStyle = (FontStyle)1;
		((Graphic)val8).color = ColorTextMain;
		val8.alignment = (TextAnchor)4;
		GameObject val9 = new GameObject("SliderControl");
		val9.transform.SetParent(val.transform, false);
		RectTransform val10 = val9.AddComponent<RectTransform>();
		val10.sizeDelta = new Vector2(200f, 20f);
		Image val11 = val9.AddComponent<Image>();
		((Graphic)val11).color = new Color(0.08f, 0.08f, 0.12f, 1f);
		Slider val12 = val9.AddComponent<Slider>();
		val12.minValue = min;
		val12.maxValue = max;
		val12.value = defaultValue;
		val12.wholeNumbers = false;
		GameObject val13 = new GameObject("Fill Area");
		val13.transform.SetParent(val9.transform, false);
		RectTransform val14 = val13.AddComponent<RectTransform>();
		val14.anchorMin = Vector2.zero;
		val14.anchorMax = Vector2.one;
		val14.sizeDelta = new Vector2(-6f, -6f);
		GameObject val15 = new GameObject("Fill");
		val15.transform.SetParent(val13.transform, false);
		RectTransform val16 = val15.AddComponent<RectTransform>();
		val16.sizeDelta = Vector2.zero;
		Image val17 = val15.AddComponent<Image>();
		((Graphic)val17).color = ColorAccent;
		val12.fillRect = val16;
		GameObject val18 = new GameObject("Handle Slide Area");
		val18.transform.SetParent(val9.transform, false);
		RectTransform val19 = val18.AddComponent<RectTransform>();
		val19.anchorMin = Vector2.zero;
		val19.anchorMax = Vector2.one;
		val19.sizeDelta = new Vector2(-6f, 0f);
		GameObject val20 = new GameObject("Handle");
		val20.transform.SetParent(val18.transform, false);
		RectTransform val21 = val20.AddComponent<RectTransform>();
		val21.sizeDelta = new Vector2(12f, 0f);
		Image val22 = val20.AddComponent<Image>();
		((Graphic)val22).color = Color.white;
		val12.handleRect = val21;
		((Selectable)val12).targetGraphic = (Graphic)(object)val22;
		GameObject val23 = new GameObject("ValueInput");
		val23.transform.SetParent(val.transform, false);
		RectTransform val24 = val23.AddComponent<RectTransform>();
		val24.sizeDelta = new Vector2(60f, 25f);
		Image val25 = val23.AddComponent<Image>();
		((Graphic)val25).color = new Color(0.1f, 0.1f, 0.15f, 1f);
		InputField val26 = val23.AddComponent<InputField>();
		GameObject val27 = new GameObject("Text");
		val27.transform.SetParent(val23.transform, false);
		RectTransform val28 = val27.AddComponent<RectTransform>();
		val28.anchorMin = Vector2.zero;
		val28.anchorMax = Vector2.one;
		val28.sizeDelta = Vector2.zero;
		Text val29 = val27.AddComponent<Text>();
		val29.text = defaultValue.ToString("F2");
		val29.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		val29.fontSize = 14;
		((Graphic)val29).color = ColorAccent;
		val29.alignment = (TextAnchor)4;
		val26.textComponent = val29;
		val26.text = defaultValue.ToString("F2");
		((UnityEvent<string>)(object)val26.onEndEdit).AddListener((UnityAction<string>)delegate(string str)
		{
			if (float.TryParse(str, out var result))
			{
				result = Mathf.Clamp(result, min, max);
				val12.value = result;
				onChange(result);
				val26.text = result.ToString("F2");
			}
		});
		((UnityEvent<float>)(object)val12.onValueChanged).AddListener((UnityAction<float>)delegate(float value)
		{
			val26.text = value.ToString("F2");
			onChange(value);
		});
	}

	public static GameObject CreateTabContent(string name)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		GameObject val = new GameObject(name);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.anchorMin = Vector2.zero;
		val2.anchorMax = Vector2.one;
		val2.sizeDelta = Vector2.zero;
		LayoutElement val3 = val.AddComponent<LayoutElement>();
		val3.minHeight = 400f;
		val3.preferredHeight = -1f;
		val3.flexibleHeight = 1f;
		ScrollRect val4 = val.AddComponent<ScrollRect>();
		val4.horizontal = false;
		val4.vertical = true;
		val4.scrollSensitivity = 30f;
		val4.movementType = (MovementType)1;
		GameObject val5 = new GameObject("Viewport");
		val5.transform.SetParent(val.transform, false);
		RectTransform val6 = val5.AddComponent<RectTransform>();
		val6.anchorMin = Vector2.zero;
		val6.anchorMax = Vector2.one;
		val6.sizeDelta = Vector2.zero;
		val6.pivot = new Vector2(0f, 1f);
		Image val7 = val5.AddComponent<Image>();
		((Graphic)val7).color = new Color(0f, 0f, 0f, 0.01f);
		Mask val8 = val5.AddComponent<Mask>();
		val8.showMaskGraphic = false;
		val4.viewport = val6;
		GameObject val9 = new GameObject("Content");
		val9.transform.SetParent(val5.transform, false);
		RectTransform val10 = val9.AddComponent<RectTransform>();
		val10.anchorMin = new Vector2(0f, 1f);
		val10.anchorMax = new Vector2(1f, 1f);
		val10.sizeDelta = new Vector2(0f, 0f);
		val10.pivot = new Vector2(0.5f, 1f);
		val4.content = val10;
		VerticalLayoutGroup val11 = val9.AddComponent<VerticalLayoutGroup>();
		RectOffset val12 = new RectOffset();
		val12.left = 12;
		val12.right = 12;
		val12.top = 12;
		val12.bottom = 12;
		((LayoutGroup)val11).padding = val12;
		((HorizontalOrVerticalLayoutGroup)val11).spacing = 8f;
		((HorizontalOrVerticalLayoutGroup)val11).childControlHeight = false;
		((HorizontalOrVerticalLayoutGroup)val11).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val11).childForceExpandHeight = false;
		((HorizontalOrVerticalLayoutGroup)val11).childForceExpandWidth = true;
		ContentSizeFitter val13 = val9.AddComponent<ContentSizeFitter>();
		val13.verticalFit = (FitMode)2;
		return val;
	}

	public static void CreateSelector(GameObject parent, string[] dataList, Func<int> getIndex, Action<int> setIndex, Action<Text> setLabelRef)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Selector");
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 40f);
		HorizontalLayoutGroup val3 = val.AddComponent<HorizontalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val3).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val3).childForceExpandWidth = true;
		((HorizontalOrVerticalLayoutGroup)val3).spacing = 10f;
		Text labelComp = null;
		Button val4 = CreateButton("<", delegate
		{
			int num = getIndex();
			num--;
			if (num < 0)
			{
				num = dataList.Length - 1;
			}
			setIndex(num);
			if ((Object)(object)labelComp != (Object)null)
			{
				labelComp.text = dataList[num];
			}
		}, val);
		((Component)val4).transform.SetParent(val.transform, false);
		LayoutElement val5 = ((Component)val4).GetComponent<LayoutElement>() ?? ((Component)val4).gameObject.AddComponent<LayoutElement>();
		val5.preferredWidth = 50f;
		val5.flexibleWidth = 0f;
		GameObject val6 = new GameObject("LabelContainer");
		val6.transform.SetParent(val.transform, false);
		Image val7 = val6.AddComponent<Image>();
		((Graphic)val7).color = ColorBgLighter;
		LayoutElement val8 = val6.AddComponent<LayoutElement>();
		val8.flexibleWidth = 1f;
		labelComp = CreateLabel(dataList[getIndex()], val6);
		labelComp.alignment = (TextAnchor)4;
		((Graphic)labelComp).color = ColorAccent;
		labelComp.fontStyle = (FontStyle)1;
		labelComp.fontSize = 14;
		RectTransform component = ((Component)labelComp).GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.sizeDelta = Vector2.zero;
		setLabelRef(labelComp);
		Button val9 = CreateButton(">", delegate
		{
			int num = getIndex();
			num++;
			if (num >= dataList.Length)
			{
				num = 0;
			}
			setIndex(num);
			if ((Object)(object)labelComp != (Object)null)
			{
				labelComp.text = dataList[num];
			}
		}, val);
		((Component)val9).transform.SetParent(val.transform, false);
		LayoutElement val10 = ((Component)val9).GetComponent<LayoutElement>() ?? ((Component)val9).gameObject.AddComponent<LayoutElement>();
		val10.preferredWidth = 50f;
		val10.flexibleWidth = 0f;
	}

	public static void CreateSpawner(GameObject parent, string title, string[] dataList, Action<int, int> onSpawn)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		GameObject val = new GameObject("Spawner_" + title);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 150f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = new Color(0.1f, 0.1f, 0.12f, 0.5f);
		Outline val4 = val.AddComponent<Outline>();
		((Shadow)val4).effectColor = new Color(0.2f, 0.8f, 1f, 0.1f);
		((Shadow)val4).effectDistance = new Vector2(1f, -1f);
		VerticalLayoutGroup val5 = val.AddComponent<VerticalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val5).spacing = 8f;
		RectOffset val6 = new RectOffset();
		val6.left = 10;
		val6.right = 10;
		val6.top = 10;
		val6.bottom = 10;
		((LayoutGroup)val5).padding = val6;
		((HorizontalOrVerticalLayoutGroup)val5).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val5).childControlHeight = false;
		((HorizontalOrVerticalLayoutGroup)val5).childForceExpandHeight = false;
		int currentIndex = 0;
		Text labelRef = null;
		CreateSelector(val, dataList, () => currentIndex, delegate(int num)
		{
			currentIndex = num;
		}, delegate(Text label)
		{
			labelRef = label;
		});
		int currentAmount = 1;
		CreateSlider("Amount", 1f, 50f, 1f, delegate(float num)
		{
			currentAmount = (int)num;
		}, val);
		CreateButton(title.ToUpper(), delegate
		{
			onSpawn(currentIndex, currentAmount);
		}, val);
		CreateSpacer(8, parent);
	}

	public static void CreateSpawnerNoSlider(GameObject parent, string title, string[] dataList, Action<int> onSpawn)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		GameObject val = new GameObject("Spawner_" + title);
		val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 110f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = new Color(0.1f, 0.1f, 0.12f, 0.5f);
		Outline val4 = val.AddComponent<Outline>();
		((Shadow)val4).effectColor = new Color(0.2f, 0.8f, 1f, 0.1f);
		((Shadow)val4).effectDistance = new Vector2(1f, -1f);
		VerticalLayoutGroup val5 = val.AddComponent<VerticalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val5).spacing = 8f;
		RectOffset val6 = new RectOffset();
		val6.left = 10;
		val6.right = 10;
		val6.top = 10;
		val6.bottom = 10;
		((LayoutGroup)val5).padding = val6;
		((HorizontalOrVerticalLayoutGroup)val5).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val5).childControlHeight = false;
		((HorizontalOrVerticalLayoutGroup)val5).childForceExpandHeight = false;
		int currentIndex = 0;
		Text labelRef = null;
		CreateSelector(val, dataList, () => currentIndex, delegate(int num)
		{
			currentIndex = num;
		}, delegate(Text label)
		{
			labelRef = label;
		});
		CreateButton(title.ToUpper(), delegate
		{
			onSpawn(currentIndex);
		}, val);
		CreateSpacer(8, parent);
	}
}
