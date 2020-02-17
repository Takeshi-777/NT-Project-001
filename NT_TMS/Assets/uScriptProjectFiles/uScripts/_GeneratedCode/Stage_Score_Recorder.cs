//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Stage_Score_Recorder : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Int32 ID_001_Count = (int) 0;
   public System.Int32 ID_002_Count = (int) 0;
   public System.Int32 ID_003_Count = (int) 0;
   public System.Int32 ID_004_Count = (int) 0;
   public System.Int32 ID_005_Count = (int) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_7 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_7 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_7;
   bool logic_uScriptAct_SetInt_Out_7 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_6 = default(UnityEngine.GameObject);
   
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
      if ( null == event_UnityEngine_GameObject_Instance_6 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_6 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_6 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_6.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_6.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_6;
                  component.uScriptLateStart += Instance_uScriptLateStart_6;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_6 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_6.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_6;
               component.uScriptLateStart -= Instance_uScriptLateStart_6;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetInt_uScriptAct_SetInt_7.SetParent(g);
   }
   public void Awake()
   {
      
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
   }
   
   public void OnDisable()
   {
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
   }
   
   void Instance_uScriptStart_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_6( );
   }
   
   void Instance_uScriptLateStart_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_6( );
   }
   
   void Relay_uScriptStart_6()
   {
      Relay_In_7();
   }
   
   void Relay_uScriptLateStart_6()
   {
   }
   
   void Relay_In_7()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_7.In(logic_uScriptAct_SetInt_Value_7, out logic_uScriptAct_SetInt_Target_7);
      ID_001_Count = logic_uScriptAct_SetInt_Target_7;
      ID_002_Count = logic_uScriptAct_SetInt_Target_7;
      ID_003_Count = logic_uScriptAct_SetInt_Target_7;
      ID_004_Count = logic_uScriptAct_SetInt_Target_7;
      ID_005_Count = logic_uScriptAct_SetInt_Target_7;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
