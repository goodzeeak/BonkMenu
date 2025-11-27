using System;
using BonkMenu.UI.Components;
using BonkMenu.UI.Tabs;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UniverseLib;
using UniverseLib.Config;
using UniverseLib.Input;

namespace BonkMenu.UI;

public static class UniverseUI
{
	private static GameObject panelRoot;

	private static GameObject[] tabContents = (GameObject[])(object)new GameObject[6];

	private static GameObject[] tabButtons = (GameObject[])(object)new GameObject[6];

	private static int currentTab = 0;

	private static bool[] tabInitialized = new bool[6];

	private static Action<GameObject>[] tabCreators;

	private static Action _onInitialized;

	private static bool isDragging = false;

	private static Vector3 lastMousePos;

	private static RectTransform headerRect;

	private static RectTransform panelRect;

	private static Font _cachedFont;

	public static void Initialize()
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		tabCreators = new Action<GameObject>[6]
		{
			delegate(GameObject root)
			{
				PlayerTab.Create(GetContent(root));
			},
			delegate(GameObject root)
			{
				CombatTab.Create(GetContent(root));
			},
			delegate(GameObject root)
			{
				ItemsTab.Create(GetContent(root));
			},
			delegate(GameObject root)
			{
				UnlocksTab.Create(GetContent(root));
			},
			delegate(GameObject root)
			{
				LootTab.Create(GetContent(root));
			},
			delegate(GameObject root)
			{
				AboutTab.Create(GetContent(root));
			}
		};
		_onInitialized = OnUniverseInitialized;

		Universe.Init(0f, _onInitialized, (Action<string, LogType>)null, default(UniverseLibConfig));
	}

	private static void OnUniverseInitialized()
	{
		try
		{
			CreateSimpleUI();

		}
		catch (Exception ex)
		{
			MelonLogger.Error("[BonkMenu] UniverseUI initialization failed: " + ex.Message);
			MelonLogger.Error(ex.StackTrace);
		}
	}

	public static void Toggle()
	{
		if ((Object)(object)panelRoot != (Object)null)
		{
			bool flag = !panelRoot.activeSelf;
			panelRoot.SetActive(flag);
			if (flag)
			{
				isDragging = false;
				EnsureTabInitialized(currentTab);
			}

		}
	}

	private static void CreateSimpleUI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		GameObject val = new GameObject("BonkMenuCanvas");
		Object.DontDestroyOnLoad((Object)(object)val);
		Canvas val2 = val.AddComponent<Canvas>();
		val2.renderMode = (RenderMode)0;
		val2.sortingOrder = 32767;
		CanvasScaler val3 = val.AddComponent<CanvasScaler>();
		val3.uiScaleMode = (ScaleMode)1;
		val3.referenceResolution = new Vector2(1920f, 1080f);
		val.AddComponent<GraphicRaycaster>();
		panelRoot = new GameObject("BonkMenuPanel");
		Object.DontDestroyOnLoad((Object)(object)panelRoot);
		panelRoot.transform.SetParent(val.transform, false);
		panelRoot.transform.SetAsLastSibling();
		panelRect = panelRoot.AddComponent<RectTransform>();
		panelRect.anchorMin = new Vector2(0.5f, 0.5f);
		panelRect.anchorMax = new Vector2(0.5f, 0.5f);
		panelRect.pivot = new Vector2(0.5f, 0.5f);
		panelRect.sizeDelta = new Vector2(600f, 650f);
		panelRect.anchoredPosition = Vector2.zero;
		Image val4 = panelRoot.AddComponent<Image>();
		((Graphic)val4).color = new Color(0.05f, 0.05f, 0.07f, 0.98f);
		((Graphic)val4).raycastTarget = true;
		GameObject val5 = new GameObject("Outline");
		val5.transform.SetParent(panelRoot.transform, false);
		RectTransform val6 = val5.AddComponent<RectTransform>();
		val6.anchorMin = Vector2.zero;
		val6.anchorMax = Vector2.one;
		val6.sizeDelta = Vector2.zero;
		Outline val7 = val5.AddComponent<Outline>();
		((Shadow)val7).effectColor = new Color(0.2f, 0.8f, 1f, 0.8f);
		((Shadow)val7).effectDistance = new Vector2(2f, 2f);
		VerticalLayoutGroup val8 = panelRoot.AddComponent<VerticalLayoutGroup>();
		((LayoutGroup)val8).padding = new RectOffset();
		((HorizontalOrVerticalLayoutGroup)val8).spacing = 0f;
		((HorizontalOrVerticalLayoutGroup)val8).childControlHeight = true;
		((HorizontalOrVerticalLayoutGroup)val8).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val8).childForceExpandHeight = false;
		((HorizontalOrVerticalLayoutGroup)val8).childForceExpandWidth = true;
		CreateHeader();
		CreateTabBar();
		CreateTabbedContent();
		panelRoot.SetActive(false);
	}

	public static void Update()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)panelRoot == (Object)null || !panelRoot.activeSelf)
		{
			return;
		}
		Vector3 mousePosition = InputManager.MousePosition;
		if (InputManager.GetMouseButtonDown(0))
		{
			if ((Object)(object)headerRect != (Object)null && RectTransformUtility.RectangleContainsScreenPoint(headerRect, (Vector2)mousePosition, (Camera)null))
			{
				isDragging = true;
				lastMousePos = mousePosition;
			}
		}
		else if (InputManager.GetMouseButtonUp(0))
		{
			isDragging = false;
		}
		if (isDragging && (Object)(object)panelRect != (Object)null)
		{
			Vector3 val = mousePosition - lastMousePos;
			RectTransform obj = panelRect;
			((Transform)obj).position = ((Transform)obj).position + val;
			lastMousePos = mousePosition;
		}
	}

	private static Font GetFont()
	{
		if ((Object)(object)_cachedFont != (Object)null)
		{
			return _cachedFont;
		}
		Font[] array = RuntimeHelper.FindObjectsOfTypeAll<Font>();
		Font[] array2 = array;
		foreach (Font val in array2)
		{
			if (((Object)val).name == "Arial")
			{
				_cachedFont = val;
				return val;
			}
		}
		if (array.Length != 0)
		{
			_cachedFont = array[0];
			return _cachedFont;
		}
		return null;
	}

	private static void CreateHeader()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("Header");
		val.transform.SetParent(panelRoot.transform, false);
		headerRect = val.AddComponent<RectTransform>();
		headerRect.sizeDelta = new Vector2(0f, 45f);
		LayoutElement val2 = val.AddComponent<LayoutElement>();
		val2.minHeight = 45f;
		val2.preferredHeight = 45f;
		val2.flexibleHeight = 0f;
		Image val3 = val.AddComponent<Image>();
		((Graphic)val3).color = new Color(0.08f, 0.08f, 0.1f, 1f);
		GameObject val4 = new GameObject("Title");
		val4.transform.SetParent(val.transform, false);
		RectTransform val5 = val4.AddComponent<RectTransform>();
		val5.anchorMin = Vector2.zero;
		val5.anchorMax = Vector2.one;
		val5.sizeDelta = new Vector2(-100f, 0f);
		val5.anchoredPosition = new Vector2(0f, 0f);
		Text val6 = val4.AddComponent<Text>();
		val6.text = "⚡ BONK MENU ⚡";
		val6.font = GetFont();
		val6.fontSize = 22;
		val6.fontStyle = (FontStyle)1;
		((Graphic)val6).color = new Color(0.2f, 0.8f, 1f, 1f);
		val6.alignment = (TextAnchor)4;
		GameObject val7 = new GameObject("ExitButton");
		val7.transform.SetParent(val.transform, false);
		RectTransform val8 = val7.AddComponent<RectTransform>();
		val8.anchorMin = new Vector2(1f, 0.5f);
		val8.anchorMax = new Vector2(1f, 0.5f);
		val8.sizeDelta = new Vector2(40f, 40f);
		val8.anchoredPosition = new Vector2(-25f, 0f);
		Image val9 = val7.AddComponent<Image>();
		((Graphic)val9).color = new Color(0.8f, 0.2f, 0.2f, 0f);
		Button val10 = val7.AddComponent<Button>();
		((Selectable)val10).targetGraphic = (Graphic)(object)val9;
		((UnityEvent)val10.onClick).AddListener((UnityAction)delegate
		{
			Toggle();
		});
		GameObject val11 = new GameObject("Text");
		val11.transform.SetParent(val7.transform, false);
		RectTransform val12 = val11.AddComponent<RectTransform>();
		val12.anchorMin = Vector2.zero;
		val12.anchorMax = Vector2.one;
		val12.sizeDelta = Vector2.zero;
		Text val13 = val11.AddComponent<Text>();
		val13.text = "✕";
		val13.font = GetFont();
		val13.fontSize = 24;
		((Graphic)val13).color = new Color(1f, 0.3f, 0.3f, 1f);
		val13.alignment = (TextAnchor)4;
		GameObject val14 = new GameObject("HeaderBorder");
		val14.transform.SetParent(val.transform, false);
		RectTransform val15 = val14.AddComponent<RectTransform>();
		val15.anchorMin = new Vector2(0f, 0f);
		val15.anchorMax = new Vector2(1f, 0f);
		val15.sizeDelta = new Vector2(0f, 2f);
		val15.pivot = new Vector2(0.5f, 0f);
		Image val16 = val14.AddComponent<Image>();
		((Graphic)val16).color = new Color(0.2f, 0.8f, 1f, 0.5f);
	}

	private static void CreateTabBar()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("TabBar");
		val.transform.SetParent(panelRoot.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.sizeDelta = new Vector2(0f, 35f);
		LayoutElement val3 = val.AddComponent<LayoutElement>();
		val3.minHeight = 35f;
		val3.preferredHeight = 35f;
		val3.flexibleHeight = 0f;
		HorizontalLayoutGroup val4 = val.AddComponent<HorizontalLayoutGroup>();
		((HorizontalOrVerticalLayoutGroup)val4).childControlWidth = true;
		((HorizontalOrVerticalLayoutGroup)val4).childControlHeight = true;
		((HorizontalOrVerticalLayoutGroup)val4).childForceExpandWidth = false;
		((HorizontalOrVerticalLayoutGroup)val4).childForceExpandHeight = true;
		((LayoutGroup)val4).childAlignment = (TextAnchor)4;
		((HorizontalOrVerticalLayoutGroup)val4).spacing = 4f;
		RectOffset val5 = new RectOffset();
		val5.left = 10;
		val5.right = 10;
		val5.top = 2;
		val5.bottom = 2;
		((LayoutGroup)val4).padding = val5;
		string[] array = new string[6] { "Player", "Combat", "Items", "Unlocks", "Loot & Spawns", "About" };
		for (int i = 0; i < array.Length; i++)
		{
			GameObject val6 = new GameObject("Tab_" + array[i]);
			val6.transform.SetParent(val.transform, false);
			tabButtons[i] = val6;
			Image val7 = val6.AddComponent<Image>();
			((Graphic)val7).color = new Color(0.1f, 0.1f, 0.12f, 1f);
			Button val8 = val6.AddComponent<Button>();
			int index = i;
			((UnityEvent)val8.onClick).AddListener((UnityAction)delegate
			{
				SwitchTab(index);
			});
			LayoutElement val9 = val6.AddComponent<LayoutElement>();
			val9.flexibleWidth = 0f;
			val9.preferredWidth = 90f;
			GameObject val10 = new GameObject("Text");
			val10.transform.SetParent(val6.transform, false);
			RectTransform val11 = val10.AddComponent<RectTransform>();
			val11.anchorMin = Vector2.zero;
			val11.anchorMax = Vector2.one;
			val11.sizeDelta = Vector2.zero;
			Text val12 = val10.AddComponent<Text>();
			val12.text = array[i];
			val12.font = GetFont();
			val12.fontSize = 12;
			val12.alignment = (TextAnchor)4;
			((Graphic)val12).color = new Color(0.7f, 0.7f, 0.8f, 1f);
		}
	}

	private static void CreateTabbedContent()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("ContentArea");
		val.transform.SetParent(panelRoot.transform, false);
		RectTransform val2 = val.AddComponent<RectTransform>();
		val2.anchorMin = Vector2.zero;
		val2.anchorMax = Vector2.one;
		val2.sizeDelta = Vector2.zero;
		LayoutElement val3 = val.AddComponent<LayoutElement>();
		val3.flexibleHeight = 1f;
		for (int i = 0; i < tabContents.Length; i++)
		{
			GameObject val4 = UIFactory.CreateTabContent($"TabContent_{i}");
			val4.transform.SetParent(val.transform, false);
			tabContents[i] = val4;
			val4.SetActive(false);
		}
		SwitchTab(0);
	}

	private static GameObject GetContent(GameObject root)
	{
		Transform val = root.transform.Find("Viewport");
		if ((Object)(object)val != (Object)null)
		{
			Transform val2 = val.Find("Content");
			if ((Object)(object)val2 != (Object)null)
			{
				return ((Component)val2).gameObject;
			}
		}
		return root;
	}

	private static void EnsureTabInitialized(int tabIndex)
	{
		if (tabIndex < 0 || tabIndex >= tabInitialized.Length || tabInitialized[tabIndex])
		{
			return;
		}

		try
		{
			tabCreators[tabIndex](tabContents[tabIndex]);
			tabInitialized[tabIndex] = true;
		}
		catch (Exception ex)
		{
			MelonLogger.Error($"[BonkMenu] UniverseUI tab {tabIndex} init failed: {ex.Message}");
		}
	}

	private static void SwitchTab(int tabIndex)
	{
		if (currentTab == tabIndex && tabContents[currentTab].activeSelf)
		{
			return;
		}
		for (int i = 0; i < tabContents.Length; i++)
		{
			if ((Object)(object)tabContents[i] != (Object)null)
			{
				tabContents[i].SetActive(false);
			}
		}
		if ((Object)(object)tabContents[tabIndex] != (Object)null)
		{
			EnsureTabInitialized(tabIndex);
			tabContents[tabIndex].SetActive(true);
		}
		currentTab = tabIndex;
		UpdateTabVisuals();
	}

	private static void UpdateTabVisuals()
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < tabButtons.Length; i++)
		{
			if (!((Object)(object)tabButtons[i] != (Object)null))
			{
				continue;
			}
			Button component = tabButtons[i].GetComponent<Button>();
			Image component2 = tabButtons[i].GetComponent<Image>();
			Transform obj = tabButtons[i].transform.Find("Text");
			Text val = ((obj != null) ? ((Component)obj).GetComponent<Text>() : null);
			if (i == currentTab)
			{
				((Graphic)component2).color = new Color(0.2f, 0.8f, 1f, 0.2f);
				if ((Object)(object)val != (Object)null)
				{
					((Graphic)val).color = new Color(0.2f, 0.8f, 1f, 1f);
					val.fontStyle = (FontStyle)1;
				}
			}
			else
			{
				((Graphic)component2).color = new Color(0.1f, 0.1f, 0.12f, 1f);
				if ((Object)(object)val != (Object)null)
				{
					((Graphic)val).color = new Color(0.6f, 0.6f, 0.65f, 1f);
					val.fontStyle = (FontStyle)0;
				}
			}
		}
	}
}
