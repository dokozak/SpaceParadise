
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IOInformation : MonoBehaviour
{

    public void SaveGame()
    {
        string file = Application.persistentDataPath + "/GameData.json";
        ValuesOfTheGame dataGame = new ValuesOfTheGame();
    string json = JsonUtility.ToJson(dataGame);

        File.WriteAllText(file, json);
    }

    public void DataCharge()
    {
        string file = Application.persistentDataPath + "/GameData.json";
        if (File.Exists(file)) 
        {
            string content = File.ReadAllText(file);
            ValuesOfTheGame dataGame = JsonUtility.FromJson<ValuesOfTheGame>(content);
            InformationPowerUpPlayer.moneyActually = dataGame.moneyActually;
            InformationPowerUpPlayer.shotVelocityLevel = dataGame.shotVelocityLevel;
            InformationPowerUpPlayer.shotUpLevel = dataGame.shotUpLevel;
            InformationPowerUpPlayer.lifeLevel = dataGame.lifeLevel;
            InformationPowerUpPlayer.emergencyButtonLevel = dataGame.emergencyButtonLevel;
            InformationPowerUpPlayer.luckyLevel = dataGame.luckyLevel;
            InformationPowerUpPlayer.powerUpLevel = dataGame.powerUpLevel;
            InformationPowerUpPlayer.fixBarrelLevel = dataGame.fixBarrelLevel; 
            InformationPowerUpPlayer.barrelLevel = dataGame.barrelLevel;
            InformationPowerUpPlayer.islaserBeam = dataGame.islaserBeam;
            InformationPowerUpPlayer.isChangeLaser = dataGame.isChangeLaser;
            Stadistics.dieTimes = dataGame.dieTimes;
            Stadistics.enemiesKilled = dataGame.enemiesKilled; 
            Stadistics.bossesDeleted = dataGame.bossesDeleted;
            Stadistics.recordOfTimeWaves = dataGame.recordOfTimeWaves;

        }
        else
        {
            InformationPowerUpPlayer.moneyActually = 0;
            InformationPowerUpPlayer.shotVelocityLevel = 1;
            InformationPowerUpPlayer.shotUpLevel = 1;
            InformationPowerUpPlayer.lifeLevel = 1;
            InformationPowerUpPlayer.emergencyButtonLevel = 1;
            InformationPowerUpPlayer.luckyLevel = 1;
            InformationPowerUpPlayer.powerUpLevel = 1;
            InformationPowerUpPlayer.fixBarrelLevel = 1;
            InformationPowerUpPlayer.barrelLevel = 1;
            InformationPowerUpPlayer.islaserBeam = false;
            InformationPowerUpPlayer.isChangeLaser = false;
            Stadistics.dieTimes = 0;
            Stadistics.enemiesKilled = 0;
            Stadistics.bossesDeleted = 0;
            Stadistics.recordOfTimeWaves = 0;
        }
    }

    public void DeleteData()
    {
        string file = Application.persistentDataPath + "/GameData.json";
        if (File.Exists(file))
        {
            File.Delete(file);
        }
        SceneManager.LoadScene("ChargeValues");

    }
}
