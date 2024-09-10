using UnityEngine;
using Zenject;

namespace MediatorExample.Scripts.AddedScripts
{
    public class GameController : MonoBehaviour
    {
        private Level _level;

        [Inject]
        private void Construct(Level level)
            => _level = level;

        private void Awake()
        {
            _level.Start();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _level.OnDefeat();
        }
    }
}