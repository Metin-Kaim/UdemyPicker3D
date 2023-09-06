
using UnityEngine;

namespace Commands.Level
{
    public class OnLovelDestroyerCommand
    {
        private Transform _levelHolder;

        public OnLovelDestroyerCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        public void Execute()
        {
            if (_levelHolder.transform.childCount <= 0) return;
            Object.Destroy(_levelHolder.transform.GetChild(0).gameObject);
        }
    }
}