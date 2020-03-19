using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildApk : Editor
{
    [MenuItem("Tool/APKBuild")]
    public static void Build()
    {
        BuildTarget buildTarget = BuildTarget.Android;
        // 切换到 Android 平台
        EditorUserBuildSettings.SwitchActiveBuildTarget(buildTarget);

        ////// keystore 路径, G:\keystore\one.keystore
        //PlayerSettings.Android.keystoreName = "F:\\keystore\\user.keystore";
        ////// one.keystore 密码
        //PlayerSettings.Android.keystorePass = "liu120423";

        ////// one.keystore 别名
        //PlayerSettings.Android.keyaliasName = "user";
        ////// 别名密码
        //PlayerSettings.Android.keyaliasPass = "liu120423";

        List<string> levels = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            // 获取有效的 Scene
            levels.Add(scene.path);
        }

        // 打包出 APK 名
        string apkName = string.Format("./{0}.apk", "woshishui");
        // 执行打包
        var res = BuildPipeline.BuildPlayer(levels.ToArray(), apkName, buildTarget, BuildOptions.None);
       
        AssetDatabase.Refresh();
    }

}
