using UnityEditor;
using UnityEngine;
using System.IO;
public class AddFileHeadComment : UnityEditor.AssetModificationProcessor
{
    public static void OnWillCreateAsset(string newFileMeta)
    {
        string newFilePath = newFileMeta.Replace(".meta", "");
        string fileExt = Path.GetExtension(newFilePath);
        if (fileExt != ".cs")
        {
            return;
        }
        string realPath = Application.dataPath.Replace("Assets", "") + newFilePath;
        string scriptContent = File.ReadAllText(realPath);

        scriptContent = scriptContent.Replace("#SCRIPTNAME#", Path.GetFileName(newFilePath));
        scriptContent = scriptContent.Replace("#AUTHOR#", "Passion");
        scriptContent = scriptContent.Replace("#CREATETIME#", System.DateTime.Now.ToString("F"));

        File.WriteAllText(realPath, scriptContent);
    }
    
}