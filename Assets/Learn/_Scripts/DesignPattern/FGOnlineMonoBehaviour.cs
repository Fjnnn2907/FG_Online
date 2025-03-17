using UnityEngine;

namespace FG.Online
{
    public class FGOnlineMonoBehaviour : MonoBehaviour
    {
        protected virtual void Reset()
        {
            LoadCompoment();
        }
        protected virtual void LoadCompoment() { }
    }
}
