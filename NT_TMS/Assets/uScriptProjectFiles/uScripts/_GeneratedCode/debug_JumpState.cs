//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class debug_JumpState : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _txtobj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _txtobj_previous = null;
   public UnityEngine.GameObject jump_state = default(UnityEngine.GameObject);
   UnityEngine.GameObject jump_state_previous = null;
   System.String local_0_System_String = "";
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_3 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_3 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_3 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_3 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_3 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_3;
   bool logic_uScriptAct_SetString_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_IntToString logic_uScriptAct_IntToString_uScriptAct_IntToString_5 = new uScriptAct_IntToString( );
   System.Int32 logic_uScriptAct_IntToString_Target_5 = (int) 0;
   uScriptAct_IntToString.FormatType logic_uScriptAct_IntToString_StandardFormat_5 = uScriptAct_IntToString.FormatType.General;
   System.String logic_uScriptAct_IntToString_CustomFormat_5 = "";
   System.String logic_uScriptAct_IntToString_CustomCulture_5 = "";
   System.String logic_uScriptAct_IntToString_Result_5;
   bool logic_uScriptAct_IntToString_Out_5 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_1 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_text_Detox_ScriptEditor_Parameter_text_4 = "";
   System.Int32 property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_6 = (int) 0;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_text_Detox_ScriptEditor_Parameter_text_4_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_txtobj != null)
      {
         component = _txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_txtobj != null)
      {
         component = _txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_4;
      }
   }
   
   System.Int32 property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_6_Get_Refresh( )
   {
      Jump_Judge_Col_Component component = null;
      if (jump_state != null)
      {
         component = jump_state.GetComponent<Jump_Judge_Col_Component>();
      }
      if ( null != component )
      {
         return component.Jump_Judge_state;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_6_Set_Refresh( )
   {
      Jump_Judge_Col_Component component = null;
      if (jump_state != null)
      {
         component = jump_state.GetComponent<Jump_Judge_Col_Component>();
      }
      if ( null != component )
      {
         component.Jump_Judge_state = property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_6;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _txtobj_previous != _txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _txtobj_previous = _txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( jump_state_previous != jump_state || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         jump_state_previous = jump_state;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _txtobj_previous != _txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _txtobj_previous = _txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( jump_state_previous != jump_state || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         jump_state_previous = jump_state;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_1 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_1 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_1 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_1.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_1;
                  component.OnLateUpdate += Instance_OnLateUpdate_1;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_1;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_1 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_1;
               component.OnLateUpdate -= Instance_OnLateUpdate_1;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetString_uScriptAct_SetString_3.SetParent(g);
      logic_uScriptAct_IntToString_uScriptAct_IntToString_5.SetParent(g);
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
   
   void Instance_OnUpdate_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_1( );
   }
   
   void Instance_OnLateUpdate_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_1( );
   }
   
   void Instance_OnFixedUpdate_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_1( );
   }
   
   void Relay_OnUpdate_1()
   {
      Relay_In_5();
   }
   
   void Relay_OnLateUpdate_1()
   {
   }
   
   void Relay_OnFixedUpdate_1()
   {
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_SetString_Value_3 = local_0_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_3.In(logic_uScriptAct_SetString_Value_3, logic_uScriptAct_SetString_ToUpperCase_3, logic_uScriptAct_SetString_ToLowerCase_3, logic_uScriptAct_SetString_TrimWhitespace_3, out logic_uScriptAct_SetString_Target_3);
      property_text_Detox_ScriptEditor_Parameter_text_4 = logic_uScriptAct_SetString_Target_3;
      property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_IntToString_Target_5 = property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_6_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_IntToString_uScriptAct_IntToString_5.In(logic_uScriptAct_IntToString_Target_5, logic_uScriptAct_IntToString_StandardFormat_5, logic_uScriptAct_IntToString_CustomFormat_5, logic_uScriptAct_IntToString_CustomCulture_5, out logic_uScriptAct_IntToString_Result_5);
      local_0_System_String = logic_uScriptAct_IntToString_Result_5;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_IntToString_uScriptAct_IntToString_5.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
}
