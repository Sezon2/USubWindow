﻿#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections;

public interface ISubWinCustomMenu
{

	void AddCustomMenu(GenericMenu menu);
}
#endif
