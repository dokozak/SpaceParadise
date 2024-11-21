
using System.IO;
using UnityEngine;

public class IOInformation : MonoBehaviour
{
    private string file;

    public InformationPowerUpPlayer dataGame = new InformationPowerUpPlayer();

    private void Awake()
    {
        file = Application.persistentDataPath + "/GameData.json";
    }

    public void SaveGame(InformationPowerUpPlayer information)
    {
        string json = JsonUtility.ToJson(information);

        File.WriteAllText(file, json);
    }

    public InformationPowerUpPlayer DataCharge()
    {
        if (File.Exists(file)) 
        {
            string content = File.ReadAllText(file);
            dataGame = JsonUtility.FromJson<InformationPowerUpPlayer>(content);
            return dataGame;
        }

        return null;
    }
}
