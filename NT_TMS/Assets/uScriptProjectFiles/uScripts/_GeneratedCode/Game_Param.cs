//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Game_Param : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_10_System_String = "on";
   System.String local_6_System_String = "Player_Jump_Vector_X";
   System.String local_7_System_String = "Player_Jump_Vector_Y";
   public System.Single pl_Side_value = (float) 150;
   public System.Single pl_Up_value = (float) 150;
   public System.Single st_pl_Side_value = (float) 150;
   public System.Single st_pl_Up_value = (float) 150;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_4 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_4 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_4 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_4;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_5 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_5 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_5 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_5;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_5 = true;
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_8 = new uScript_GraphEvents( );
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_9 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_9 = "";
   System.Object[] logic_uScriptAct_Log_Target_9 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_9 = "";
   bool logic_uScriptAct_Log_Out_9 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_4.SetParent(g);
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_5.SetParent(g);
      logic_uScript_GraphEvents_uScript_GraphEvents_8.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_9.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptEnable += uScript_GraphEvents_uScriptEnable_8;
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptDisable += uScript_GraphEvents_uScriptDisable_8;
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_8;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
      logic_uScript_GraphEvents_uScript_GraphEvents_8.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_8.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_8.OnDestroy( );
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptEnable -= uScript_GraphEvents_uScriptEnable_8;
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptDisable -= uScript_GraphEvents_uScriptDisable_8;
      logic_uScript_GraphEvents_uScript_GraphEvents_8.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_8;
   }
   
   void uScript_GraphEvents_uScriptEnable_8(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_8( );
   }
   
   void uScript_GraphEvents_uScriptDisable_8(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_8( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_8(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_8( );
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_4 = local_6_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_4.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_4, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_4, out logic_uScriptAct_GetPreferenceKeyFloat_Value_4);
      st_pl_Side_value = logic_uScriptAct_GetPreferenceKeyFloat_Value_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_5 = local_7_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_5.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_5, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_5, out logic_uScriptAct_GetPreferenceKeyFloat_Value_5);
      st_pl_Up_value = logic_uScriptAct_GetPreferenceKeyFloat_Value_5;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_uScriptEnable_8()
   {
      Relay_In_4();
   }
   
   void Relay_uScriptDisable_8()
   {
   }
   
   void Relay_uScriptDestroy_8()
   {
   }
   
   void Relay_In_9()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_9.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_9, index + 1);
            }
            logic_uScriptAct_Log_Target_9[ index++ ] = local_10_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_9.In(logic_uScriptAct_Log_Prefix_9, logic_uScriptAct_Log_Target_9, logic_uScriptAct_Log_Postfix_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
