using System.IO;
using UnityEditor;
using UnityEngine;

namespace danyatesdev
{
    public static class ToolsMenu
    {
        [MenuItem("Custom Tools/Setup/Create default folders")]
        public static void CreateDefaultFolders()
        {
            GenerateFolders("Assets", "Assetstore", "Materials");
            GenerateFolders("Assets/Imported", "Art", "Fonts", "Models", "Sound");
            GenerateFolders("Default");
            GenerateFolders("Prefabs");
            GenerateFolders("Resources");
            GenerateFolders("Scenes");
            GenerateFolders("Scripts", "Gameplay", "Managers", "Utilities");
            AssetDatabase.Refresh();
        }

        private static void GenerateFolders(string rootFolder, params string[] folderNames)
        {
            foreach (var folderName in folderNames)
            {
                Directory.CreateDirectory(Path.Combine(Application.dataPath, rootFolder, folderName));
            }
        }
    }
}
