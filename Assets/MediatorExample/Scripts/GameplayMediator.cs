using UnityEngine;
using Zenject;

public class GameplayMediator: MonoBehaviour
{
    private DefeatPanel _defeatPanel;
    private Level _level;

    [Inject]
    private void Construct(Level level, DefeatPanel defeatPanel)
    {
        _defeatPanel = defeatPanel;
        _level = level;
        
        _level.Defeat += OnDefeat;
        _defeatPanel.ClickedRestartLevel += OnClickedRestartLevel;
    }

    private void OnClickedRestartLevel()
        => RestartLevel();

    private void OnDestroy()
    {
        _level.Defeat -= OnDefeat;
        _defeatPanel.ClickedRestartLevel -= OnClickedRestartLevel;
    }

    private void OnDefeat() => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
    }
}
