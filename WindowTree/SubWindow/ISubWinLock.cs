#if UNITY_EDITOR
using UnityEngine;
using System.Collections;

public interface ISubWinLock
{
	void SetLockActive(bool isLockActive);
}
#endif
