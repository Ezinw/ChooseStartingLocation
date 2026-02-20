using MelonLoader;
using UnityEngine;

namespace ChooseStartingLocation
{
    public class Implementation : MelonMod
    {
        public static Location startLocation = new Location();

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}
