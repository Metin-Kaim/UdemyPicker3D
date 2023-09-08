
using UnityEngine;

namespace Commands.Level
{
    public class OnLovelDestroyerCommand
    {
        private Transform _levelHolder;

        internal OnLovelDestroyerCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        internal void Execute()
        {
            if (_levelHolder.transform.childCount <= 0) return;
            Object.Destroy(_levelHolder.transform.GetChild(0).gameObject);
        }
    }
}