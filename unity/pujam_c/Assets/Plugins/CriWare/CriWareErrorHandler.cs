﻿/****************************************************************************
 *
 * CRIWARE Unity Plugin
 *
 * Copyright (c) 2012 CRI Middleware Co.,Ltd.
 *
 * Library  : CRI Ware
 * Module   : CRI Ware Error Handler
 * File     : CriWareErrorHandler.cs
 *
 ****************************************************************************/
using UnityEngine;
using System;
using System.Runtime.InteropServices;

/*JP
 * \brief CRIWAREエラーオブジェクト
 * \ingroup WARE_UNITY_COMPONENT
 * \par 説明:
 * CRIWAREライブラリの初期化を行うためのコンポーネントです。<br>
 */
[AddComponentMenu("CRIWARE/Error Handler")]
public class CriWareErrorHandler : MonoBehaviour {
	/* Unityデバッグウィンドウだけでなく、コンソールデバッグ出力を有効にするかどうか [deprecated] */
	/* PCの場合はデバッグウィンドウに出力されます。 */
	public bool enableDebugPrintOnTerminal = false;
	
	/*JP< シーンチェンジ時にエラーハンドラを削除するかどうか */
	public bool dontDestoryOnLoad = true;
	
	/* エラーメッセージ */
	public static string errorMessage { get; set; }
	
	/* オブジェクト作成時の処理 */
	void Awake() {
		/* 初期化カウンタの更新 */
		initializationCount++;
		if (initializationCount != 1) {
			/* 多重初期化は許可しない */
			GameObject.Destroy(this);
			return;
		}
		
		/* エラー処理の初期化 */
		criWareUnity_Initialize();
		
		/* ターミナルへのログ出力表示切り替え */
		criWareUnity_ControlLogOutput(enableDebugPrintOnTerminal);
		
		/* シーンチェンジ後もオブジェクトを維持するかどうかの設定 */
		if (dontDestoryOnLoad) {
			DontDestroyOnLoad(transform.gameObject);
		}
	}
	
	/* Execution Order の設定を確実に有効にするために OnEnable をオーバーライド */
	void OnEnable() {
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_ANDROID || UNITY_IOS
		if (enableDebugPrintOnTerminal == false){
			/* iOS/Androidの場合、エラーメッセージの出力先が重複してしまうため、*/
			/* ターミナル出力が無効になっている場合のみ、Unity出力を有効にする。*/
			OutputErrorMessage();
		}
#else
		OutputErrorMessage();
#endif
	}
	
	void OnDestroy() {
		/* 初期化カウンタの更新 */
		initializationCount--;
		if (initializationCount != 0) {
			return;
		}
		
		/* エラー処理の終了処理 */
		criWareUnity_Finalize();
	}
	
	/* エラーメッセージのポーリングと出力 */
	private static void OutputErrorMessage() 
	{
		/* エラーメッセージのポーリング */
		System.IntPtr ptr = criWareUnity_GetFirstError();
		if (ptr == IntPtr.Zero) {
			return;
		}

		/* Unity上でログ出力 */
		string message = Marshal.PtrToStringAnsi(ptr);
		if (message != string.Empty) {
			OutputLog(message);
			criWareUnity_ResetError();
		}
		
		if (CriWareErrorHandler.errorMessage == null) {
			CriWareErrorHandler.errorMessage = string.Copy(message);
		}
	}

	/* ログの出力 */
	private static void OutputLog(string errmsg)
	{
		if (errmsg == null) {
			return;
		}
		
		if (errmsg.StartsWith("E")) {
			Debug.LogError("[CRIWARE] Error:" + errmsg);
		} else if (errmsg.StartsWith("W")) {
			Debug.LogWarning("[CRIWARE] Warning:" + errmsg);
		} else {
			Debug.Log("[CRIWARE]" + errmsg);
		}
	}
	
	/* 初期化カウンタ */
	private static int initializationCount = 0;
	
	#region DLLImport
	[DllImport(CriWare.pluginName)]
	private static extern void criWareUnity_Initialize();

	[DllImport(CriWare.pluginName)]
	private static extern void criWareUnity_Finalize();

	[DllImport(CriWare.pluginName)]
	private static extern System.IntPtr criWareUnity_GetFirstError();

	[DllImport(CriWare.pluginName)]
	private static extern void criWareUnity_ResetError();

	[DllImport(CriWare.pluginName)]
	private static extern void criWareUnity_ControlLogOutput(bool sw);
	#endregion	
}

/* --- end of file --- */
