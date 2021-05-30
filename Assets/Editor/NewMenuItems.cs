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

        [MenuItem("CONTEXT/Rigidbody/NewOption")]
        private static void NewOptionForRigidbody()
        {
            Debug.Log("Teste de um submenu no Rigidbody");
        }
        
        [MenuItem("Assets/ProcessTexture")]
        private static void DoSomethingWithTexture()
        {
        }

        // Note that we pass the same path, and also pass "true" to the second argument.
        [MenuItem("Assets/ProcessTexture", true)]
        private static bool NewMenuOptionValidation()
        {
            // This returns true when the selected object is a Texture2D (the menu item will be disabled otherwise).
            return Selection.activeObject.GetType() == typeof(Texture2D);
        }
        
        [MenuItem("NewMenu/Option1", false, 1)]
        private static void NewMenuOption()
        {
        }

        [MenuItem("NewMenu/Option2", false, 2)]
        private static void NewMenuOption2()
        {
        }

        [MenuItem("NewMenu/Option3", false, 3)]
        private static void NewMenuOption3()
        {
        }

        [MenuItem("NewMenu/Option4", false, 51)]
        private static void NewMenuOption4()
        {
        }

        [MenuItem("NewMenu/Option5", false, 52)]
        private static void NewMenuOption5()
        {
        }
        
        [MenuItem("CONTEXT/RigidBody/New Option")]
        private static void NewMenuOption(MenuCommand menuCommand)
        {
            // The RigidBody component can be extracted from the menu command using the context field.
            var rigid = menuCommand.context as Rigidbody;
        }

    }
}
