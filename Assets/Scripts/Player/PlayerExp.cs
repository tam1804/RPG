using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public void AddExp(float amout)
    {
        while(stats.CurrentExp >= stats.NextLevelExp)
        {
            stats.CurrentExp -= stats.NextLevelExp;
            NextLevel();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddExp(300f);
        }   
    }

    private void NextLevel()
    {
        stats.Level++;
        float currentExpRequired = stats.NextLevelExp;
        float newNextLevelExp = Mathf.Round(currentExpRequired + stats.NextLevelExp*(stats.ExpMultiplier/100f));
        stats.NextLevelExp = newNextLevelExp;
    }
}
