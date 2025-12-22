using System;
using UnityEngine;
using UnityEngine.Events;
using BonkMenu.Core;
using UnityEngine.UI;
using UniverseLib;
using UniverseLib.Input;

namespace BonkMenu.UI.Components;

/// <summary>
/// Helper factory for building BonkMenu UI elements and controls.
/// </summary>
public static class UIFactory
{
    private class ToastRef
    {
        public GameObject go;
        public Text text;
        public Text icon;
        public Image bg;
        public float expireAt;
        public int count;
        public string baseLabel;
    }
    private static System.Collections.Generic.Dictionary<string, ToastRef> _spawnToasts = new System.Collections.Generic.Dictionary<string, ToastRef>();
    private static readonly Color ColorBgDark = new Color(0.08f, 0.08f, 0.1f, 1f);

	private static readonly Color ColorBgLighter = new Color(0.1f, 0.1f, 0.12f, 1f);

    private static readonly Color ColorBgInput = new Color(0f, 0f, 0f, 1f);

	private static readonly Color ColorAccent = new Color(0.2f, 0.8f, 1f, 1f);

	private static readonly Color ColorAccentDim = new Color(0.2f, 0.8f, 1f, 0.3f);

    private static readonly Color ColorTextMain = new Color(1f, 1f, 1f, 1f);

    private static readonly Color ColorTextDim = new Color(0.7f, 0.7f, 0.8f, 1f);

    /// <summary>
    /// Creates a styled section header with title and separator line.
    /// </summary>
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
        ((Graphic)val5).color = ColorTextMain;
        val5.alignment = (TextAnchor)4;
		GameObject val6 = new GameObject("Line");
		val6.transform.SetParent(val.transform, false);
		Image val7 = val6.AddComponent<Image>();
		((Graphic)val7).color = ColorAccentDim;
		LayoutElement val8 = val6.AddComponent<LayoutElement>();
		val8.minHeight = 2f;
		val8.preferredHeight = 2f;
	}

    /// <summary>
    /// Creates a button with label and click handler under the parent.
    /// </summary>
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
		val2.sizeDelta = new Vector2(0f, 30f);
        LayoutElement le = val.AddComponent<LayoutElement>();
        le.preferredHeight = 30f;
        le.minHeight = 30f;
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = ColorBgDark;
		Button val4 = val.AddComponent<Button>();
		((Selectable)val4).targetGraphic = (Graphic)(object)val3;
		((UnityEvent)val4.onClick).AddListener((UnityAction)onClick);
		ColorBlock colors = ((Selectable)val4).colors;
		colors.normalColor = ColorBgDark;
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
        val8.fontSize = 13;
        val8.fontStyle = (FontStyle)0;
        ((Graphic)val8).color = ColorTextMain;
        val8.alignment = (TextAnchor)4;
		return val4;
	}

    /// <summary>
    /// Creates a simple text label under the parent.
    /// </summary>
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
        val3.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        val3.fontSize = 13;
        ((Graphic)val3).color = ColorTextDim;
        val3.alignment = (TextAnchor)4;
        return val3;
    }

    /// <summary>
    /// Displays a keybind row with action name and bound key.
    /// </summary>
    public static void CreateKeybindRow(string action, KeyCode key, GameObject parent)
    {
        CreateKeybindRow(action, () => key, _ => { }, parent);
    }

    // Interactive keybind rows use central capture in BonkMenuMod

    public static void CreateKeybindRow(string action, System.Func<KeyCode> get, System.Action<KeyCode> set, GameObject parent)
    {
        GameObject row = new GameObject("Keybind_" + action);
        row.transform.SetParent(parent.transform, false);
        RectTransform rt = row.AddComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, 28f);
        HorizontalLayoutGroup h = row.AddComponent<HorizontalLayoutGroup>();
        ((HorizontalOrVerticalLayoutGroup)h).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)h).childControlHeight = true;
        ((HorizontalOrVerticalLayoutGroup)h).spacing = 6f;
        h.childForceExpandWidth = false;
        ((LayoutGroup)h).childAlignment = (TextAnchor)3;
        RectOffset pad = new RectOffset();
        pad.left = 10;
        pad.right = 10;
        pad.top = 4;
        pad.bottom = 4;
        ((LayoutGroup)h).padding = pad;
        Image bg = row.AddComponent<Image>();
        ((Graphic)bg).color = ColorBgDark;
        Outline outline = row.AddComponent<Outline>();
        ((Shadow)outline).effectColor = new Color(0f, 0f, 0f, 0.35f);
        ((Shadow)outline).effectDistance = new Vector2(1f, -1f);

        GameObject left = new GameObject("Action");
        left.transform.SetParent(row.transform, false);
        RectTransform lrt = left.AddComponent<RectTransform>();
        lrt.sizeDelta = new Vector2(0f, 28f);
        Text ltxt = left.AddComponent<Text>();
        ltxt.text = action;
        ltxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        ltxt.fontSize = 13;
        ((Graphic)ltxt).color = ColorTextMain;
        ltxt.alignment = (TextAnchor)3;
        LayoutElement lle = left.AddComponent<LayoutElement>();
        lle.flexibleWidth = 1f;

        GameObject right = new GameObject("Key");
        right.transform.SetParent(row.transform, false);
        RectTransform rrt = right.AddComponent<RectTransform>();
        rrt.sizeDelta = new Vector2(0f, 28f);
        Text rtxt = right.AddComponent<Text>();
        rtxt.text = BonkMenu.Core.KeybindConfig.FormatKeyLabel(action, get());
        rtxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        rtxt.fontSize = 13;
        ((Graphic)rtxt).color = ColorTextMain;
        rtxt.alignment = (TextAnchor)5;
        LayoutElement rle = right.AddComponent<LayoutElement>();
        rle.preferredWidth = 120f;
        rle.flexibleWidth = 0f;

        Button btn = row.AddComponent<Button>();
        ((Selectable)btn).targetGraphic = (Graphic)(object)bg;
        ColorBlock cb = ((Selectable)btn).colors;
        cb.normalColor = ColorBgDark;
        cb.highlightedColor = new Color(0.25f, 0.25f, 0.35f, 1f);
        cb.pressedColor = new Color(0.1f, 0.1f, 0.15f, 1f);
        cb.selectedColor = cb.normalColor;
        cb.colorMultiplier = 1f;
        cb.fadeDuration = 0.1f;
        RuntimeHelper.SetColorBlock((Selectable)(object)btn, cb);

        ((UnityEngine.Events.UnityEvent)btn.onClick).AddListener((UnityEngine.Events.UnityAction)(() => {
            rtxt.text = "Press a key...";
            KeybindConfig.BeginCapture(action, get, set, (labelText) => { rtxt.text = labelText; });
        }));
    }

    /// <summary>
    /// Inserts vertical space in the layout.
    /// </summary>
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

    /// <summary>
    /// Creates a collapsible container with a header and builds its content.
    /// </summary>
    public static GameObject CreateCollapsibleSection(string title, GameObject parent, Action<GameObject> build, bool defaultOpen = false)
    {
        GameObject root = new GameObject("Collapsible_" + title);
        root.transform.SetParent(parent.transform, false);
        RectTransform rt = root.AddComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, 0f);
        VerticalLayoutGroup vlg = root.AddComponent<VerticalLayoutGroup>();
        ((HorizontalOrVerticalLayoutGroup)vlg).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)vlg).childControlHeight = true;
        ((HorizontalOrVerticalLayoutGroup)vlg).spacing = 4f;
        ((LayoutGroup)vlg).childAlignment = (TextAnchor)4;
        ContentSizeFitter rootFit = root.AddComponent<ContentSizeFitter>();
        rootFit.verticalFit = (FitMode)2;
        rootFit.horizontalFit = (FitMode)0;

        GameObject header = new GameObject("Header");
        header.transform.SetParent(root.transform, false);
        RectTransform hrt = header.AddComponent<RectTransform>();
        hrt.sizeDelta = new Vector2(0f, 35f);
        Image hbg = header.AddComponent<Image>();
        ((Graphic)hbg).color = ColorBgLighter;
        Outline hOutline = header.AddComponent<Outline>();
        ((Shadow)hOutline).effectColor = new Color(0f, 0f, 0f, 0.4f);
        ((Shadow)hOutline).effectDistance = new Vector2(1f, -1f);
        LayoutElement headerLE = header.AddComponent<LayoutElement>();
        headerLE.preferredHeight = 35f;

        GameObject hTextGO = new GameObject("Text");
        hTextGO.transform.SetParent(header.transform, false);
        RectTransform hTextRT = hTextGO.AddComponent<RectTransform>();
        hTextRT.anchorMin = Vector2.zero;
        hTextRT.anchorMax = Vector2.one;
        hTextRT.sizeDelta = Vector2.zero;
        Text hText = hTextGO.AddComponent<Text>();
        hText.text = title.ToUpper();
        hText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        hText.fontSize = 14;
        ((Graphic)hText).color = ColorTextMain;
        hText.alignment = (TextAnchor)4;

        GameObject content = new GameObject("Content");
        content.transform.SetParent(root.transform, false);
        RectTransform crt = content.AddComponent<RectTransform>();
        crt.sizeDelta = new Vector2(0f, 0f);
        VerticalLayoutGroup cvlg = content.AddComponent<VerticalLayoutGroup>();
        ((HorizontalOrVerticalLayoutGroup)cvlg).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)cvlg).childControlHeight = true;
        ((HorizontalOrVerticalLayoutGroup)cvlg).spacing = 6f;
        ((LayoutGroup)cvlg).childAlignment = (TextAnchor)3;
        ContentSizeFitter contentFit = content.AddComponent<ContentSizeFitter>();
        contentFit.verticalFit = (FitMode)2;
        contentFit.horizontalFit = (FitMode)0;

        content.SetActive(true);
        try
        {
            build(content);
        }
        catch
        {
            // keep header visible even if build fails
        }
        LayoutRebuilder.ForceRebuildLayoutImmediate(crt);
        LayoutRebuilder.ForceRebuildLayoutImmediate(rt);
        return root;
    }

    /// <summary>
    /// Creates a checkbox-like toggle with a label.
    /// </summary>
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
		val2.sizeDelta = new Vector2(0f, 30f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = ColorBgDark;
		HorizontalLayoutGroup val4 = val.AddComponent<HorizontalLayoutGroup>();
		RectOffset val5 = new RectOffset();
		val5.left = 10;
		val5.right = 10;
		val5.top = 5;
		val5.bottom = 5;
		((LayoutGroup)val4).padding = val5;
        ((HorizontalOrVerticalLayoutGroup)val4).spacing = 15f;
        ((HorizontalOrVerticalLayoutGroup)val4).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)val4).childForceExpandWidth = false;
        ((LayoutGroup)val4).childAlignment = (TextAnchor)3;
        GameObject val6 = new GameObject("Checkbox");
        val6.transform.SetParent(val.transform, false);
        RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.sizeDelta = new Vector2(18f, 18f);
		var le6 = val6.AddComponent<LayoutElement>();
		le6.minWidth = 18f; le6.minHeight = 18f; le6.preferredWidth = 18f; le6.preferredHeight = 18f; le6.flexibleWidth = 0f; le6.flexibleHeight = 0f;
        var ar6 = val6.AddComponent<AspectRatioFitter>();
        ar6.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        ar6.aspectRatio = 1f;
		Image val8 = val6.AddComponent<Image>();
		((Graphic)val8).color = ColorBgLighter;
        Toggle val9 = val6.AddComponent<Toggle>();
        val9.isOn = initialValue;
        ((Selectable)val9).targetGraphic = (Graphic)(object)val8;
        ((UnityEvent<bool>)(object)val9.onValueChanged).AddListener((UnityAction<bool>)onChange);
		Button rowBtn = val.AddComponent<Button>();
		((Selectable)rowBtn).targetGraphic = (Graphic)(object)val3;
		ColorBlock rb = ((Selectable)rowBtn).colors;
		rb.normalColor = ColorBgDark;
		rb.highlightedColor = new Color(0.25f, 0.25f, 0.35f, 1f);
		rb.pressedColor = new Color(0.1f, 0.1f, 0.15f, 1f);
		rb.selectedColor = rb.normalColor;
		rb.colorMultiplier = 1f;
		rb.fadeDuration = 0.1f;
		RuntimeHelper.SetColorBlock((Selectable)(object)rowBtn, rb);
		((UnityEvent)rowBtn.onClick).AddListener((UnityAction)(() => { val9.isOn = !val9.isOn; }));
		GameObject val10 = new GameObject("Checkmark");
		val10.transform.SetParent(val6.transform, false);
        RectTransform val11 = val10.AddComponent<RectTransform>();
        val11.anchorMin = Vector2.zero;
        val11.anchorMax = Vector2.one;
		val11.sizeDelta = new Vector2(0f, 0f);
        var ar10 = val10.AddComponent<AspectRatioFitter>();
        ar10.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
        ar10.aspectRatio = 1f;
        Image val12 = val10.AddComponent<Image>();
        ((Graphic)val12).color = ColorAccent;
        val9.graphic = (Graphic)(object)val12;
        ((Graphic)val12).CrossFadeAlpha(initialValue ? 1f : 0f, 0f, true);
        ((UnityEvent<bool>)(object)val9.onValueChanged).AddListener((UnityAction<bool>)((bool v) => {
            ((Graphic)val12).CrossFadeAlpha(v ? 1f : 0f, 0.12f, true);
        }));
		GameObject val13 = new GameObject("Label");
		val13.transform.SetParent(val.transform, false);
		RectTransform val14 = val13.AddComponent<RectTransform>();
		val14.sizeDelta = new Vector2(0f, 25f);
		Text val15 = val13.AddComponent<Text>();
		val15.text = label;
		val15.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        val15.fontSize = 13;
		val15.fontStyle = (FontStyle)0;
		((Graphic)val15).color = ColorTextMain;
		val15.alignment = (TextAnchor)3;
		LayoutElement labelLE = val13.AddComponent<LayoutElement>();
		labelLE.flexibleWidth = 1f;
	}

	public static void CreateSquareToggleTile(string label, string icon, bool initialValue, Action<bool> onChange, GameObject parent)
	{
		GameObject root = new GameObject("ToggleTile_" + label);
		root.transform.SetParent(parent.transform, false);
		RectTransform rt = root.AddComponent<RectTransform>();
		rt.sizeDelta = new Vector2(100f, 100f);
		LayoutElement le = root.AddComponent<LayoutElement>();
		le.preferredWidth = 100f;
		le.preferredHeight = 100f;
		le.flexibleWidth = 0f;
		le.flexibleHeight = 0f;
		Image bg = root.AddComponent<Image>();
		((Graphic)bg).color = ColorBgDark;
		Toggle tg = root.AddComponent<Toggle>();
		tg.isOn = initialValue;
		((Selectable)tg).targetGraphic = (Graphic)(object)bg;
		((UnityEvent<bool>)(object)tg.onValueChanged).AddListener((UnityAction<bool>)onChange);
		ColorBlock cb = ((Selectable)tg).colors;
		cb.normalColor = ColorBgDark;
		cb.highlightedColor = new Color(0.25f, 0.25f, 0.35f, 1f);
		cb.pressedColor = new Color(0.1f, 0.1f, 0.15f, 1f);
		cb.selectedColor = cb.normalColor;
		cb.colorMultiplier = 1f;
		cb.fadeDuration = 0.1f;
		RuntimeHelper.SetColorBlock((Selectable)(object)tg, cb);
		Outline outline = root.AddComponent<Outline>();
		((Shadow)outline).effectColor = new Color(0f, 0f, 0f, 0.5f);
		((Shadow)outline).effectDistance = new Vector2(1f, -1f);
		VerticalLayoutGroup vlg = root.AddComponent<VerticalLayoutGroup>();
		RectOffset pad = new RectOffset();
		pad.left = 8; pad.right = 8; pad.top = 8; pad.bottom = 8;
		((LayoutGroup)vlg).padding = pad;
		((HorizontalOrVerticalLayoutGroup)vlg).spacing = 6f;
		((HorizontalOrVerticalLayoutGroup)vlg).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)vlg).childControlHeight = true;
		((HorizontalOrVerticalLayoutGroup)vlg).childForceExpandWidth = true;
		((HorizontalOrVerticalLayoutGroup)vlg).childForceExpandHeight = false;
		((LayoutGroup)vlg).childAlignment = (TextAnchor)4;
		GameObject iconGO = new GameObject("Icon");
		iconGO.transform.SetParent(root.transform, false);
		RectTransform iconRT = iconGO.AddComponent<RectTransform>();
		iconRT.sizeDelta = new Vector2(0f, 32f);
		Text iconTxt = iconGO.AddComponent<Text>();
		iconTxt.text = icon ?? string.Empty;
		iconTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		iconTxt.fontSize = 24;
        ((Graphic)iconTxt).color = ColorTextMain;
		iconTxt.alignment = (TextAnchor)4;
		GameObject labelGO = new GameObject("Label");
		labelGO.transform.SetParent(root.transform, false);
		RectTransform lrt = labelGO.AddComponent<RectTransform>();
		lrt.sizeDelta = new Vector2(0f, 22f);
		Text ltxt = labelGO.AddComponent<Text>();
		ltxt.text = label;
		ltxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        ltxt.fontSize = 13;
		ltxt.fontStyle = (FontStyle)0;
		((Graphic)ltxt).color = ColorTextMain;
		ltxt.alignment = (TextAnchor)4;
		LayoutElement lle = labelGO.AddComponent<LayoutElement>();
		lle.flexibleWidth = 1f;
		GameObject checkGO = new GameObject("Checkmark");
		checkGO.transform.SetParent(root.transform, false);
		RectTransform crt2 = checkGO.AddComponent<RectTransform>();
		crt2.anchorMin = Vector2.zero;
		crt2.anchorMax = Vector2.one;
		crt2.sizeDelta = new Vector2(-12f, -12f);
		Text checkTxt = checkGO.AddComponent<Text>();
		checkTxt.text = "✓";
		checkTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		checkTxt.fontSize = 28;
        ((Graphic)checkTxt).color = ColorTextMain;
		checkTxt.alignment = (TextAnchor)4;
		LayoutElement cle = checkGO.AddComponent<LayoutElement>();
		cle.ignoreLayout = true;
		tg.graphic = (Graphic)(object)checkTxt;
	}

    /// <summary>
    /// Creates a slider with label, numeric input, and change callback.
    /// </summary>
    public static void CreateSlider(string label, float min, float max, float defaultValue, Action<float> onChange, GameObject parent, bool isPercentage = false, bool isMultiplier = false)
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
		((Graphic)val3).color = ColorBgDark;
		HorizontalLayoutGroup val4 = val.AddComponent<HorizontalLayoutGroup>();
		RectOffset val5 = new RectOffset();
		val5.left = 10;
		val5.right = 10;
		val5.top = 5;
		val5.bottom = 5;
		((LayoutGroup)val4).padding = val5;
		((HorizontalOrVerticalLayoutGroup)val4).spacing = 15f;
		((HorizontalOrVerticalLayoutGroup)val4).childControlWidth = false;
        ((LayoutGroup)val4).childAlignment = (TextAnchor)4;
		GameObject val6 = new GameObject("Label");
		val6.transform.SetParent(val.transform, false);
		RectTransform val7 = val6.AddComponent<RectTransform>();
		val7.sizeDelta = new Vector2(140f, 25f);
		Text val8 = val6.AddComponent<Text>();
		val8.text = label;
		val8.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        val8.fontSize = 13;
		val8.fontStyle = (FontStyle)0;
		((Graphic)val8).color = ColorTextMain;
		val8.alignment = (TextAnchor)4;
		GameObject val9 = new GameObject("SliderControl");
		val9.transform.SetParent(val.transform, false);
		RectTransform val10 = val9.AddComponent<RectTransform>();
		val10.sizeDelta = new Vector2(200f, 20f);
        Image val11 = val9.AddComponent<Image>();
        ((Graphic)val11).color = ColorBgInput;
		Slider val12 = val9.AddComponent<Slider>();
        bool largeRange = max - min >= 1000f;
        float sliderMin = min;
        float sliderMax = (largeRange ? Mathf.Min(max, min + 1000f) : max);
		val12.minValue = sliderMin;
		val12.maxValue = sliderMax;
        val12.wholeNumbers = false;
        bool suppressSliderCallback = false;
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
        ((Graphic)val25).color = ColorBgInput;
		InputField val26 = val23.AddComponent<InputField>();
		GameObject val27 = new GameObject("Text");
		val27.transform.SetParent(val23.transform, false);
		RectTransform val28 = val27.AddComponent<RectTransform>();
        val28.anchorMin = Vector2.zero;
        val28.anchorMax = Vector2.one;
		val28.sizeDelta = Vector2.zero;
		Text val29 = val27.AddComponent<Text>();
        float clampedDefault = Mathf.Clamp(defaultValue, min, max);
        float initialSliderValue = Mathf.Clamp(clampedDefault, sliderMin, sliderMax);
        val12.value = initialSliderValue;
        string suffix = "";
        if (isPercentage)
        {
            suffix = "%";
        }
        else if (isMultiplier)
        {
            suffix = "x";
        }
        string initialText = clampedDefault.ToString("F2") + suffix;
		val29.text = initialText;
		val29.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        val29.fontSize = 13;
        ((Graphic)val29).color = ColorTextMain;
		val29.alignment = (TextAnchor)4;
		val26.textComponent = val29;
		val26.text = initialText;
		((UnityEvent<string>)(object)val26.onEndEdit).AddListener((UnityAction<string>)delegate(string str)
		{
            string input = (str ?? "").Trim();
            if (!string.IsNullOrEmpty(suffix) && input.EndsWith(suffix, StringComparison.Ordinal))
            {
                input = input.Substring(0, input.Length - suffix.Length).TrimEnd();
            }
			if (float.TryParse(input, out var result))
			{
                float clamped = Mathf.Clamp(result, min, max);
                suppressSliderCallback = true;
                float sliderTarget = Mathf.Clamp(clamped, sliderMin, sliderMax);
                val12.value = sliderTarget;
                suppressSliderCallback = false;
                string txt2 = clamped.ToString("F2") + suffix;
                val26.text = txt2;
                onChange(clamped);
			}
			else
			{
                val26.text = val26.text;
			}
		});
		((UnityEvent<float>)(object)val12.onValueChanged).AddListener((UnityAction<float>)delegate(float value)
		{
            if (suppressSliderCallback)
            {
                return;
            }
            float clamped = Mathf.Clamp(value, min, max);
            string txt3 = clamped.ToString("F2") + suffix;
			val26.text = txt3;
			onChange(clamped);
		});
	}

    /// <summary>
    /// Shows a short-lived toast notification.
    /// </summary>
    public static void ShowToast(string message)
    {
        if (!ModConfig.EnableToasts) return;
        GameObject canvas = GameObject.Find("BonkMenuCanvas");
        if ((UnityEngine.Object)canvas == (UnityEngine.Object)null) return;
        Transform t = canvas.transform.Find("ToastContainer");
        GameObject container;
        if ((UnityEngine.Object)t == (UnityEngine.Object)null)
        {
            container = new GameObject("ToastContainer");
            container.transform.SetParent(canvas.transform, false);
            RectTransform crt = container.AddComponent<RectTransform>();
            crt.anchorMin = new Vector2(1f, 0f);
            crt.anchorMax = new Vector2(1f, 0f);
            crt.pivot = new Vector2(1f, 0f);
            crt.anchoredPosition = new Vector2(-12f, 12f);
            VerticalLayoutGroup v = container.AddComponent<VerticalLayoutGroup>();
            ((HorizontalOrVerticalLayoutGroup)v).spacing = 6f;
            ((HorizontalOrVerticalLayoutGroup)v).childControlHeight = true;
            ((HorizontalOrVerticalLayoutGroup)v).childControlWidth = true;
            ((HorizontalOrVerticalLayoutGroup)v).childForceExpandHeight = false;
            ((HorizontalOrVerticalLayoutGroup)v).childForceExpandWidth = false;
            ((LayoutGroup)v).childAlignment = (TextAnchor)8;
            ContentSizeFitter fit = container.AddComponent<ContentSizeFitter>();
            fit.verticalFit = (FitMode)2;
            fit.horizontalFit = (FitMode)2;
        }
        else
        {
            container = t.gameObject;
        }

        GameObject toast = new GameObject("Toast");
        toast.transform.SetParent(container.transform, false);
        RectTransform rt = toast.AddComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, 34f);
        Image bg = toast.AddComponent<Image>();
        ((Graphic)bg).color = new Color(0.06f, 0.06f, 0.08f, 0.96f);
        Outline outline = toast.AddComponent<Outline>();
        ((Shadow)outline).effectColor = new Color(0f, 0f, 0f, 0.35f);
        ((Shadow)outline).effectDistance = new Vector2(1f, -1f);
        HorizontalLayoutGroup h = toast.AddComponent<HorizontalLayoutGroup>();
        RectOffset pad = new RectOffset();
        pad.left = 2; pad.right = 10; pad.top = 4; pad.bottom = 4;
        ((LayoutGroup)h).padding = pad;
        ((HorizontalOrVerticalLayoutGroup)h).spacing = 6f;
        ((HorizontalOrVerticalLayoutGroup)h).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)h).childControlHeight = true;
        ((HorizontalOrVerticalLayoutGroup)h).childForceExpandWidth = true;
        ((LayoutGroup)h).childAlignment = (TextAnchor)8;
        LayoutElement le = toast.AddComponent<LayoutElement>();
        le.preferredHeight = 34f;
        le.flexibleWidth = 1f;
        ContentSizeFitter toastFit = toast.AddComponent<ContentSizeFitter>();
        toastFit.horizontalFit = (FitMode)2;

        Color accentColor = ColorAccent;
        string lower = (message ?? "").ToLowerInvariant();

        GameObject accentGO = new GameObject("Accent");
        accentGO.transform.SetParent(toast.transform, false);
        RectTransform art = accentGO.AddComponent<RectTransform>();
        art.sizeDelta = new Vector2(4f, 0f);
        Image accentImg = accentGO.AddComponent<Image>();
        ((Graphic)accentImg).color = accentColor;
        LayoutElement ale = accentGO.AddComponent<LayoutElement>();
        ale.preferredWidth = 4f;
        ale.flexibleWidth = 0f;

        GameObject iconGO = new GameObject("Icon");
        iconGO.transform.SetParent(toast.transform, false);
        RectTransform iconRT = iconGO.AddComponent<RectTransform>();
        iconRT.sizeDelta = new Vector2(20f, 20f);
        Text iconTxt = iconGO.AddComponent<Text>();
        iconTxt.text = "•";
        iconTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        iconTxt.fontSize = 16;
        ((Graphic)iconTxt).color = accentColor;
        iconTxt.alignment = (TextAnchor)4;
        LayoutElement ile = iconGO.AddComponent<LayoutElement>();
        ile.preferredWidth = 24f;
        ile.flexibleWidth = 0f;

        GameObject txtGO = new GameObject("Text");
        txtGO.transform.SetParent(toast.transform, false);
        RectTransform txtRT = txtGO.AddComponent<RectTransform>();
        txtRT.anchorMin = Vector2.zero;
        txtRT.anchorMax = Vector2.one;
        txtRT.sizeDelta = Vector2.zero;
        Text txt = txtGO.AddComponent<Text>();
        txt.text = message;
        txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        txt.fontSize = 13;
        ((Graphic)txt).color = ColorTextMain;
        txt.alignment = (TextAnchor)4;
        LayoutElement tle = txtGO.AddComponent<LayoutElement>();
        tle.flexibleWidth = 1f;

        ((Graphic)bg).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)bg).CrossFadeAlpha(1f, 0.12f, true);
        ((Graphic)txt).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)txt).CrossFadeAlpha(1f, 0.12f, true);
        ((Graphic)iconTxt).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)iconTxt).CrossFadeAlpha(1f, 0.12f, true);

        Object.Destroy(toast, 2.3f);
    }

    /// <summary>
    /// Increments or creates a spawn toast counter.
    /// </summary>
    public static void IncrementSpawnToast(string key, string label)
    {
        if (!ModConfig.EnableToasts) return;
        IncrementSpawnToast(key, label, 1);
    }

    /// <summary>
    /// Increments a spawn toast counter by a specific amount.
    /// </summary>
    public static void IncrementSpawnToast(string key, string label, int increment)
    {
        if (!ModConfig.EnableToasts) return;
        GameObject canvas = GameObject.Find("BonkMenuCanvas");
        if ((UnityEngine.Object)canvas == (UnityEngine.Object)null) return;
        Transform t = canvas.transform.Find("ToastContainer");
        GameObject container = (UnityEngine.Object)t == (UnityEngine.Object)null ? null : t.gameObject;
        if ((UnityEngine.Object)container == (UnityEngine.Object)null)
        {
            container = new GameObject("ToastContainer");
            container.transform.SetParent(canvas.transform, false);
            RectTransform crt = container.AddComponent<RectTransform>();
            crt.anchorMin = new Vector2(1f, 0f);
            crt.anchorMax = new Vector2(1f, 0f);
            crt.pivot = new Vector2(1f, 0f);
            crt.anchoredPosition = new Vector2(-12f, 12f);
            VerticalLayoutGroup v = container.AddComponent<VerticalLayoutGroup>();
            ((HorizontalOrVerticalLayoutGroup)v).spacing = 6f;
            ((HorizontalOrVerticalLayoutGroup)v).childControlHeight = true;
            ((HorizontalOrVerticalLayoutGroup)v).childControlWidth = true;
            ((HorizontalOrVerticalLayoutGroup)v).childForceExpandHeight = false;
            ((HorizontalOrVerticalLayoutGroup)v).childForceExpandWidth = false;
            ((LayoutGroup)v).childAlignment = (TextAnchor)8;
            ContentSizeFitter fit = container.AddComponent<ContentSizeFitter>();
            fit.verticalFit = (FitMode)2;
            fit.horizontalFit = (FitMode)2;
        }

        ToastRef tr;
        if (!_spawnToasts.TryGetValue(key, out tr) || (UnityEngine.Object)tr.go == (UnityEngine.Object)null)
        {
            GameObject toast = new GameObject("Toast_Spawn_" + key);
            toast.transform.SetParent(container.transform, false);
            RectTransform rt = toast.AddComponent<RectTransform>();
            rt.sizeDelta = new Vector2(0f, 34f);
            Image bg = toast.AddComponent<Image>();
            ((Graphic)bg).color = new Color(0.06f, 0.06f, 0.08f, 0.96f);
            Outline outline = toast.AddComponent<Outline>();
            ((Shadow)outline).effectColor = new Color(0f, 0f, 0f, 0.35f);
            ((Shadow)outline).effectDistance = new Vector2(1f, -1f);
            HorizontalLayoutGroup h = toast.AddComponent<HorizontalLayoutGroup>();
            RectOffset pad = new RectOffset();
            pad.left = 2; pad.right = 10; pad.top = 4; pad.bottom = 4;
            ((LayoutGroup)h).padding = pad;
            ((HorizontalOrVerticalLayoutGroup)h).spacing = 6f;
            ((HorizontalOrVerticalLayoutGroup)h).childControlWidth = true;
            ((HorizontalOrVerticalLayoutGroup)h).childControlHeight = true;
            ((HorizontalOrVerticalLayoutGroup)h).childForceExpandWidth = true;
            ((LayoutGroup)h).childAlignment = (TextAnchor)8;
            LayoutElement le = toast.AddComponent<LayoutElement>();
            le.preferredHeight = 34f;
            le.flexibleWidth = 1f;
            ContentSizeFitter toastFit = toast.AddComponent<ContentSizeFitter>();
            toastFit.horizontalFit = (FitMode)2;

            GameObject accentGO = new GameObject("Accent");
            accentGO.transform.SetParent(toast.transform, false);
            RectTransform art = accentGO.AddComponent<RectTransform>();
            art.sizeDelta = new Vector2(4f, 0f);
            Image accentImg = accentGO.AddComponent<Image>();
            ((Graphic)accentImg).color = new Color(0.2f, 0.85f, 0.55f, 1f);
            LayoutElement ale = accentGO.AddComponent<LayoutElement>();
            ale.preferredWidth = 4f;
            ale.flexibleWidth = 0f;

            GameObject iconGO = new GameObject("Icon");
            iconGO.transform.SetParent(toast.transform, false);
            RectTransform iconRT = iconGO.AddComponent<RectTransform>();
            iconRT.sizeDelta = new Vector2(20f, 20f);
            Text iconTxt = iconGO.AddComponent<Text>();
            iconTxt.text = "•";
            iconTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            iconTxt.fontSize = 16;
            ((Graphic)iconTxt).color = new Color(0.2f, 0.85f, 0.55f, 1f);
            iconTxt.alignment = (TextAnchor)4;
            LayoutElement ile = iconGO.AddComponent<LayoutElement>();
            ile.preferredWidth = 24f;
            ile.flexibleWidth = 0f;

            GameObject txtGO = new GameObject("Text");
            txtGO.transform.SetParent(toast.transform, false);
            RectTransform txtRT = txtGO.AddComponent<RectTransform>();
            txtRT.anchorMin = Vector2.zero;
            txtRT.anchorMax = Vector2.one;
            txtRT.sizeDelta = Vector2.zero;
            Text txt = txtGO.AddComponent<Text>();
            txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            txt.fontSize = 13;
            ((Graphic)txt).color = ColorTextMain;
            txt.alignment = (TextAnchor)4;
            LayoutElement tle = txtGO.AddComponent<LayoutElement>();
            tle.flexibleWidth = 1f;

            tr = new ToastRef { go = toast, text = txt, icon = iconTxt, bg = bg, count = 0, expireAt = 0f, baseLabel = label };
            _spawnToasts[key] = tr;
        }

        tr.count += Math.Max(1, increment);
        if (string.IsNullOrEmpty(tr.baseLabel)) tr.baseLabel = label;
        tr.text.text = tr.count > 1 ? ("Spawned " + tr.baseLabel + " ×" + tr.count) : ("Spawned " + tr.baseLabel);
        tr.expireAt = Time.unscaledTime + 2.5f;
        ((Graphic)tr.bg).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)tr.bg).CrossFadeAlpha(1f, 0.12f, true);
        ((Graphic)tr.text).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)tr.text).CrossFadeAlpha(1f, 0.12f, true);
        ((Graphic)tr.icon).CrossFadeAlpha(0f, 0f, true);
        ((Graphic)tr.icon).CrossFadeAlpha(1f, 0.12f, true);
    }

    /// <summary>
    /// Updates and cleans up active toast notifications.
    /// </summary>
    public static void TickToasts()
    {
        if (!ModConfig.EnableToasts)
        {
            var keysAll = new System.Collections.Generic.List<string>(_spawnToasts.Keys);
            for (int i = 0; i < keysAll.Count; i++)
            {
                var tr = _spawnToasts[keysAll[i]];
                if (tr != null && (UnityEngine.Object)tr.go != (UnityEngine.Object)null)
                    Object.Destroy(tr.go);
            }
            _spawnToasts.Clear();
            return;
        }
        float now = Time.unscaledTime;
        var keys = new System.Collections.Generic.List<string>(_spawnToasts.Keys);
        for (int i = 0; i < keys.Count; i++)
        {
            var k = keys[i];
            var tr = _spawnToasts[k];
            if (tr == null || (UnityEngine.Object)tr.go == (UnityEngine.Object)null || now >= tr.expireAt)
            {
                if (tr != null && (UnityEngine.Object)tr.go != (UnityEngine.Object)null)
                    Object.Destroy(tr.go);
                _spawnToasts.Remove(k);
            }
        }
    }

    /// <summary>
    /// Sets a toggle control to the given value by label.
    /// </summary>
	public static void SetToggleState(string label, bool value)
	{
		var roots = UniverseLib.RuntimeHelper.FindObjectsOfTypeAll<GameObject>();
		for (int i = 0; i < roots.Length; i++)
		{
			var go = roots[i];
			if (go != null && (go.name == ("Toggle_" + label) || go.name == ("ToggleTile_" + label)))
			{
				Toggle tg = null;
				var checkbox = go.transform.Find("Checkbox");
				if ((UnityEngine.Object)checkbox != (UnityEngine.Object)null)
				{
					tg = checkbox.GetComponent<Toggle>();
				}
				if ((UnityEngine.Object)tg == (UnityEngine.Object)null)
				{
					tg = go.GetComponent<Toggle>();
				}
				if ((UnityEngine.Object)tg != (UnityEngine.Object)null)
				{
					tg.isOn = value;
				}
			}
		}
	}

    /// <summary>
    /// Creates a scrollable tab content root.
    /// </summary>
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
        ((LayoutGroup)val11).childAlignment = (TextAnchor)4;
		ContentSizeFitter val13 = val9.AddComponent<ContentSizeFitter>();
		val13.verticalFit = (FitMode)2;
		return val;
	}

    /// <summary>
    /// Creates a left/right selector with a label bound to an index.
    /// </summary>
    public static void CreateSelector(GameObject parent, string[] dataList, Func<int> getIndex, Action<int> setIndex, Action<Text> setLabelRef)
    {
        GameObject root = new GameObject("Selector");
        root.transform.SetParent(parent.transform, false);
        RectTransform rt = root.AddComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, 40f);
        LayoutElement le = root.AddComponent<LayoutElement>();
        le.preferredHeight = 40f;
        le.minHeight = 40f;
        HorizontalLayoutGroup hlg = root.AddComponent<HorizontalLayoutGroup>();
        ((HorizontalOrVerticalLayoutGroup)hlg).childControlWidth = true;
        ((HorizontalOrVerticalLayoutGroup)hlg).childForceExpandWidth = false;
        ((HorizontalOrVerticalLayoutGroup)hlg).spacing = 10f;
        ((LayoutGroup)hlg).childAlignment = (TextAnchor)4;

        Text labelComp = null;

        Button left = CreateButton("◀", () =>
        {
            int idx = getIndex();
            idx--;
            if (idx < 0)
            {
                idx = dataList.Length - 1;
            }
            setIndex(idx);
            if ((Object)(object)labelComp != (Object)null)
            {
                labelComp.text = dataList[idx];
            }
        }, root);
        LayoutElement leftLe = ((Component)left).GetComponent<LayoutElement>() ?? ((Component)left).gameObject.AddComponent<LayoutElement>();
        leftLe.preferredWidth = 42f;
        leftLe.flexibleWidth = 0f;

        GameObject card = new GameObject("LabelContainer");
        card.transform.SetParent(root.transform, false);
        Image cardImg = card.AddComponent<Image>();
		((Graphic)cardImg).color = ColorBgDark;
        Outline cardOutline = card.AddComponent<Outline>();
        ((Shadow)cardOutline).effectColor = new Color(0f, 0f, 0f, 0f);
        ((Shadow)cardOutline).effectDistance = new Vector2(1f, -1f);
        LayoutElement cardLe = card.AddComponent<LayoutElement>();
        cardLe.flexibleWidth = 1f;

        string initial = dataList.Length > 0 ? dataList[getIndex()] : "None";
        labelComp = CreateLabel(initial, card);
        labelComp.alignment = (TextAnchor)4;
        ((Graphic)labelComp).color = ColorTextMain;
        labelComp.fontStyle = (FontStyle)1;
        labelComp.fontSize = 13;
        labelComp.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        RectTransform lrt = ((Component)labelComp).GetComponent<RectTransform>();
        lrt.anchorMin = Vector2.zero;
        lrt.anchorMax = Vector2.one;
        lrt.sizeDelta = Vector2.zero;
        setLabelRef(labelComp);

        Button right = CreateButton("▶", () =>
        {
            int idx = getIndex();
            idx++;
            if (idx >= dataList.Length)
            {
                idx = 0;
            }
            setIndex(idx);
            if ((Object)(object)labelComp != (Object)null)
            {
                labelComp.text = dataList[idx];
            }
        }, root);
        LayoutElement rightLe = ((Component)right).GetComponent<LayoutElement>() ?? ((Component)right).gameObject.AddComponent<LayoutElement>();
        rightLe.preferredWidth = 42f;
        rightLe.flexibleWidth = 0f;
    }

    /// <summary>
    /// Creates a spawner widget with selector and amount slider.
    /// </summary>
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
		((Graphic)val3).color = new Color(0f, 0f, 0f, 0f);
        Outline val4 = val.AddComponent<Outline>();
        ((Shadow)val4).effectColor = new Color(0f, 0f, 0f, 0.4f);
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
        ((LayoutGroup)val5).childAlignment = (TextAnchor)4;
        int currentAmount = 1;
        CreateSlider("Amount", 1f, 100f, 1f, delegate(float num)
        {
            currentAmount = (int)num;
        }, val);
        int currentIndex = 0;
        Text labelRef = null;
        CreateSelector(val, dataList, () => currentIndex, (int num) => currentIndex = num, (Text lbl) => { labelRef = lbl; });
        CreateButton(title.ToUpper(), delegate
        {
            onSpawn(currentIndex, currentAmount);
        }, val);
        CreateSpacer(8, parent);
	}

    /// <summary>
    /// Creates a spawner widget with selector and a single-click action.
    /// </summary>
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
		((Graphic)val3).color = new Color(0f, 0f, 0f, 0f);
        Outline val4 = val.AddComponent<Outline>();
        ((Shadow)val4).effectColor = new Color(0f, 0f, 0f, 0.4f);
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
        ((LayoutGroup)val5).childAlignment = (TextAnchor)4;
        int currentIndex = 0;
        Text labelRef = null;
        CreateSelector(val, dataList, () => currentIndex, (int num) => currentIndex = num, (Text lbl) => { labelRef = lbl; });
        CreateButton(title.ToUpper(), delegate
        {
            onSpawn(currentIndex);
        }, val);
        CreateSpacer(8, parent);
    }

    public static void CreateSpawnerNoSlider(GameObject parent, string title, string[] dataList, Action<int> onPrimary, string secondaryTitle, Action<int> onSecondary)
    {
        GameObject val = new GameObject("Spawner_" + title);
        val.transform.SetParent(parent.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 140f);
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = new Color(0f, 0f, 0f, 0f);
        Outline val4 = val.AddComponent<Outline>();
        ((Shadow)val4).effectColor = new Color(0f, 0f, 0f, 0.4f);
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
        ((LayoutGroup)val5).childAlignment = (TextAnchor)4;
        int currentIndex = 0;
        Text labelRef = null;
        CreateSelector(val, dataList, () => currentIndex, (int num) => currentIndex = num, (Text lbl) => { labelRef = lbl; });
        GameObject grid = new GameObject("ButtonGrid");
        grid.transform.SetParent(val.transform, false);
        RectTransform grt = grid.AddComponent<RectTransform>();
        grt.sizeDelta = new Vector2(0f, 0f);
        GridLayoutGroup glg = grid.AddComponent<GridLayoutGroup>();
        glg.cellSize = new Vector2(283f, 30f);
        glg.spacing = new Vector2(10f, 8f);
        glg.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        glg.constraintCount = 2;
        ContentSizeFitter fit = grid.AddComponent<ContentSizeFitter>();
        fit.verticalFit = FitMode.PreferredSize;
        LayoutElement gle = grid.AddComponent<LayoutElement>();
        gle.flexibleWidth = 1f;
        CreateButton(title.ToUpper(), delegate
        {
            onPrimary(currentIndex);
        }, grid);
        CreateButton(secondaryTitle.ToUpper(), delegate
        {
            onSecondary(currentIndex);
        }, grid);
        CreateSpacer(8, parent);
    }
}
