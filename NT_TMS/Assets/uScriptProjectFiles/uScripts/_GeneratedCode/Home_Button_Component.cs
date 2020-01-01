//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Home_Button")]
public class Home_Button_Component : uScriptCode
{
   #pragma warning disable 414
   public Home_Button ExposedVariables = new Home_Button( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject Button_obj { get { return ExposedVariables.Button_obj; } set { ExposedVariables.Button_obj = value; } } 
   public System.Boolean BtnSet_Bool { get { return ExposedVariables.BtnSet_Bool; } set { ExposedVariables.BtnSet_Bool = value; } } 
   public UnityEngine.GameObject send_sigobj { get { return ExposedVariables.send_sigobj; } set { ExposedVariables.send_sigobj = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
      }
   #endif
}
