/****************************************************************************
*
* CRI Middleware SDK
*
* Copyright (c) 2011-2012 CRI Middleware Co.,Ltd.
*
* Library  : CRI Atom
* Module   : CRI Atom for Unity
* File     : CriAtomProjInfo_Unity.cs
* Tool Ver.          : CRI Atom Craft LE Ver.1.30.00
* Date Time          : 2013/06/30 16:50
* Project Name       : pujamC-2013.06.30
* Project Comment    : 
*
****************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class CriAtomAcfInfo
{
    static partial void GetCueInfoInternal()
    {
        acfInfo = new AcfInfo("ACF", 0, "", "pujamC-2013.acf","26d512ea-3e61-4949-9004-616ba8fb04b9","DspBusSetting_0");
        acfInfo.aisacControlNameList.Add("Any");
        acfInfo.aisacControlNameList.Add("Distance");
        acfInfo.aisacControlNameList.Add("AisacControl02");
        acfInfo.aisacControlNameList.Add("AisacControl03");
        acfInfo.aisacControlNameList.Add("AisacControl04");
        acfInfo.aisacControlNameList.Add("AisacControl05");
        acfInfo.aisacControlNameList.Add("AisacControl06");
        acfInfo.aisacControlNameList.Add("AisacControl07");
        acfInfo.aisacControlNameList.Add("AisacControl08");
        acfInfo.aisacControlNameList.Add("AisacControl09");
        acfInfo.aisacControlNameList.Add("AisacControl10");
        acfInfo.aisacControlNameList.Add("AisacControl11");
        acfInfo.aisacControlNameList.Add("AisacControl12");
        acfInfo.aisacControlNameList.Add("AisacControl13");
        acfInfo.aisacControlNameList.Add("AisacControl14");
        acfInfo.aisacControlNameList.Add("AisacControl15");
        acfInfo.acbInfoList.Clear();
        AcbInfo newAcbInfo = null;
        newAcbInfo = new AcbInfo("CueSheet_pujamC", 0, "", "CueSheet_pujamC.acb", "CueSheet_pujamC_streamfiles.awb","92af3342-cc22-43db-9fe9-c125c4cabde6");
        acfInfo.acbInfoList.Add(newAcbInfo);
        newAcbInfo.cueInfoList.Add(0, new CueInfo("tri", 0, ""));
        newAcbInfo.cueInfoList.Add(1, new CueInfo("noise", 1, ""));
        newAcbInfo.cueInfoList.Add(2, new CueInfo("BGM", 2, ""));
        newAcbInfo.cueInfoList.Add(3, new CueInfo("fall", 3, ""));
        newAcbInfo.cueInfoList.Add(4, new CueInfo("gerogero", 4, ""));
        newAcbInfo.cueInfoList.Add(5, new CueInfo("gerogero2", 5, ""));
        newAcbInfo.cueInfoList.Add(6, new CueInfo("MOoo", 6, ""));
        newAcbInfo.cueInfoList.Add(7, new CueInfo("Un", 7, ""));
        newAcbInfo.cueInfoList.Add(8, new CueInfo("Tokkazo", 8, ""));
        newAcbInfo.cueInfoList.Add(9, new CueInfo("Baka", 9, ""));
        newAcbInfo.cueInfoList.Add(10, new CueInfo("Kirai", 10, ""));
        newAcbInfo.cueInfoList.Add(11, new CueInfo("BARGAIN", 11, ""));
        newAcbInfo.cueInfoList.Add(12, new CueInfo("Yatta", 12, ""));
        newAcbInfo.cueInfoList.Add(14, new CueInfo("Title", 14, ""));
        newAcbInfo.cueInfoList.Add(15, new CueInfo("Jungle", 15, ""));
        newAcbInfo.cueInfoList.Add(18, new CueInfo("heaven_0", 18, ""));
        newAcbInfo.cueInfoList.Add(17, new CueInfo("HEAVEN2", 17, ""));
        newAcbInfo.cueInfoList.Add(19, new CueInfo("pujamC-test", 19, ""));
        newAcbInfo.cueInfoList.Add(20, new CueInfo("BGM-idling", 20, ""));
        newAcbInfo.cueInfoList.Add(21, new CueInfo("BGM-dropop", 21, ""));
        newAcbInfo.cueInfoList.Add(22, new CueInfo("BGM-water", 22, ""));
        newAcbInfo.cueInfoList.Add(24, new CueInfo("SE-popoporo", 24, ""));
        newAcbInfo.cueInfoList.Add(25, new CueInfo("SE-pipipi", 25, ""));
        newAcbInfo.cueInfoList.Add(26, new CueInfo("SE-bowa", 26, ""));
        newAcbInfo.cueInfoList.Add(27, new CueInfo("SE-piroro", 27, ""));
        newAcbInfo.cueInfoList.Add(28, new CueInfo("SE-po", 28, ""));
        newAcbInfo.cueInfoList.Add(29, new CueInfo("SE-gyuii", 29, ""));
        newAcbInfo.cueInfoList.Add(30, new CueInfo("SE-jump1", 30, ""));
        newAcbInfo.cueInfoList.Add(31, new CueInfo("SE-powa", 31, ""));
        newAcbInfo.cueInfoList.Add(32, new CueInfo("SE-jump2", 32, ""));
        newAcbInfo.cueInfoList.Add(33, new CueInfo("BGM-rutata2", 33, ""));
        newAcbInfo.cueInfoList.Add(34, new CueInfo("SE-pipishi", 34, ""));
        newAcbInfo.cueInfoList.Add(35, new CueInfo("SE-GOMAopen", 35, ""));
    }
}
