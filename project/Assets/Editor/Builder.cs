using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

public class Builder
{
    public static void Build()
    {
        string assetFolderPath = Application.dataPath;
        string filename = assetFolderPath + "/../builds/MyGame.exe";

        var scenes = EditorBuildSettings.scenes;
        var levels = scenes.Select(z => z.path).ToArray();

        BuildPipeline.BuildPlayer(levels, filename, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
