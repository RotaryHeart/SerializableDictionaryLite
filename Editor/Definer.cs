using System.Collections.Generic;
using UnityEditor;

namespace RotaryHeart.Lib.SerializableDictionary
{
    [InitializeOnLoad]
    public class SerializableDictionaryDefiner : Definer
    {
        static SerializableDictionaryDefiner()
        {
            List<string> defines = new List<string>(1)
            {
                "RH_SerializedDictionary"
            };
            
            ApplyDefines(defines);
        }
    }
}