using UnityEditor;
using UnityEngine;

namespace Editor
{
    
    public class NewMenuItems
    {
        [MenuItem("Window/Criar novo objeto")]
        private static void CreateNewObject()
        {
            Debug.Log("Criando um novo objeto");
        }

        [MenuItem("Tools/SubMenu/Opções")]
        private static void TestingSubMenu()
        {
            Debug.Log("Teste de um submenu");
        }
    }
}
