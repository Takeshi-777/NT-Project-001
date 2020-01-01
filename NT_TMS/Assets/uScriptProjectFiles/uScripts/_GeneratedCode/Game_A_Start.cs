//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Game_A_Start : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _000_StageRoot_Obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _000_StageRoot_Obj_previous = null;
   public UnityEngine.GameObject Height_txt_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Height_txt_obj_previous = null;
   UnityEngine.KeyCode local_12_UnityEngine_KeyCode = UnityEngine.KeyCode.Space;
   System.String local_Choise_stg_System_String = "Choise_stg";
   UnityEngine.GameObject local_Main_Stage_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Main_Stage_UnityEngine_GameObject_previous = null;
   System.Int32 local_Stg_int_System_Int32 = (int) 0;
   public UnityEngine.GameObject PlayerRoot = default(UnityEngine.GameObject);
   UnityEngine.GameObject PlayerRoot_previous = null;
   public UnityEngine.GameObject stage_txt_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject stage_txt_obj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyInt logic_uScriptAct_GetPreferenceKeyInt_uScriptAct_GetPreferenceKeyInt_3 = new uScriptAct_GetPreferenceKeyInt( );
   System.String logic_uScriptAct_GetPreferenceKeyInt_KeyName_3 = "";
   System.Int32 logic_uScriptAct_GetPreferenceKeyInt_DefaultValue_3 = (int) 0;
   System.Int32 logic_uScriptAct_GetPreferenceKeyInt_Value_3;
   bool logic_uScriptAct_GetPreferenceKeyInt_Out_3 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_6 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_6 = (int) 1;
   System.Int32 logic_uScriptCon_CompareInt_B_6 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_6 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_6 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_6 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_6 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_6 = true;
   bool logic_uScriptCon_CompareInt_LessThan_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_8 = "Stage_001";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_8 = "Stage/";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_8 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_8 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_8 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_8 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_8;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_8;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_8 = (bool) false;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_8 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_11 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_11 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_11 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_11 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_11 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_13 = (int) 3;
   System.Int32 logic_uScriptCon_CompareInt_B_13 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_13 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_13 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_13 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_13 = true;
   bool logic_uScriptCon_CompareInt_LessThan_13 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_14 = "Stage_002";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_14 = "Stage/";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_14 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_14 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_14 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_14;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_14;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_14 = (bool) false;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_18 = "Stage_003";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_18 = "Stage/";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_18 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_18 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_18 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_18;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_18 = (bool) false;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_18 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_19 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_19 = (int) 5;
   System.Int32 logic_uScriptCon_CompareInt_B_19 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_19 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_19 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_19 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_19 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_19 = true;
   bool logic_uScriptCon_CompareInt_LessThan_19 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_21 = "Stage_004";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_21 = "Stage/";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_21 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_21 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_21 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_21 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_21;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_21;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_21 = (bool) false;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_21 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_24 = "Stage_005";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_24 = "Stage/";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_24 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_24 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_24 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_24 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_24;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_24;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_24 = (bool) false;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_24 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_29 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_29 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_29 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_29 = "";
   System.String logic_uScriptAct_FloatToString_CustomCulture_29 = "";
   System.String logic_uScriptAct_FloatToString_Result_29;
   bool logic_uScriptAct_FloatToString_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_30 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_30 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_30 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_30 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_30 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_30;
   bool logic_uScriptAct_SetString_Out_30 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_81 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_81 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_81 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_81 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_10 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_Stage_Name_Detox_ScriptEditor_Parameter_Stage_Name_25 = "";
   System.String property_text_Detox_ScriptEditor_Parameter_text_26 = "";
   System.Single property_height_Value_Detox_ScriptEditor_Parameter_height_Value_28 = (float) 0;
   System.String property_text_Detox_ScriptEditor_Parameter_text_31 = "";
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_Stage_Name_Detox_ScriptEditor_Parameter_Stage_Name_25_Get_Refresh( )
   {
      Stage_Param_Component component = null;
      if (local_Main_Stage_UnityEngine_GameObject != null)
      {
         component = local_Main_Stage_UnityEngine_GameObject.GetComponent<Stage_Param_Component>();
      }
      if ( null != component )
      {
         return component.Stage_Name;
      }
      else
      {
         return "";
      }
   }
   
   void property_Stage_Name_Detox_ScriptEditor_Parameter_Stage_Name_25_Set_Refresh( )
   {
      Stage_Param_Component component = null;
      if (local_Main_Stage_UnityEngine_GameObject != null)
      {
         component = local_Main_Stage_UnityEngine_GameObject.GetComponent<Stage_Param_Component>();
      }
      if ( null != component )
      {
         component.Stage_Name = property_Stage_Name_Detox_ScriptEditor_Parameter_Stage_Name_25;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_26_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (stage_txt_obj != null)
      {
         component = stage_txt_obj.GetComponent<UnityEngine.UI.Text>();
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
   
   void property_text_Detox_ScriptEditor_Parameter_text_26_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (stage_txt_obj != null)
      {
         component = stage_txt_obj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_26;
      }
   }
   
   System.Single property_height_Value_Detox_ScriptEditor_Parameter_height_Value_28_Get_Refresh( )
   {
      Stage_Param_Component component = null;
      if (local_Main_Stage_UnityEngine_GameObject != null)
      {
         component = local_Main_Stage_UnityEngine_GameObject.GetComponent<Stage_Param_Component>();
      }
      if ( null != component )
      {
         return component.height_Value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_height_Value_Detox_ScriptEditor_Parameter_height_Value_28_Set_Refresh( )
   {
      Stage_Param_Component component = null;
      if (local_Main_Stage_UnityEngine_GameObject != null)
      {
         component = local_Main_Stage_UnityEngine_GameObject.GetComponent<Stage_Param_Component>();
      }
      if ( null != component )
      {
         component.height_Value = property_height_Value_Detox_ScriptEditor_Parameter_height_Value_28;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_31_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (Height_txt_obj != null)
      {
         component = Height_txt_obj.GetComponent<UnityEngine.UI.Text>();
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
   
   void property_text_Detox_ScriptEditor_Parameter_text_31_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (Height_txt_obj != null)
      {
         component = Height_txt_obj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_31;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == _000_StageRoot_Obj || false == m_RegisteredForEvents )
      {
         _000_StageRoot_Obj = GameObject.Find( "Stage_root" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Height_txt_obj_previous != Height_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Height_txt_obj_previous = Height_txt_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( stage_txt_obj_previous != stage_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         stage_txt_obj_previous = stage_txt_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( PlayerRoot_previous != PlayerRoot || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         PlayerRoot_previous = PlayerRoot;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Height_txt_obj_previous != Height_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Height_txt_obj_previous = Height_txt_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( stage_txt_obj_previous != stage_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         stage_txt_obj_previous = stage_txt_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( PlayerRoot_previous != PlayerRoot || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         PlayerRoot_previous = PlayerRoot;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_10 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_10 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_10 )
         {
            {
               uScript_Input component = event_UnityEngine_GameObject_Instance_10.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_10.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_10;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_10 )
      {
         {
            uScript_Input component = event_UnityEngine_GameObject_Instance_10.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_10;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetPreferenceKeyInt_uScriptAct_GetPreferenceKeyInt_3.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_6.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_11.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_19.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_29.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_30.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_8;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_14;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_21;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_24;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.OnOut += uScriptAct_Toggle_OnOut_81;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.OffOut += uScriptAct_Toggle_OffOut_81;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.ToggleOut += uScriptAct_Toggle_ToggleOut_81;
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
      
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8.Update( );
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14.Update( );
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.Update( );
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21.Update( );
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_8;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_14;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_21;
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_24;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.OnOut -= uScriptAct_Toggle_OnOut_81;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.OffOut -= uScriptAct_Toggle_OffOut_81;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.ToggleOut -= uScriptAct_Toggle_ToggleOut_81;
   }
   
   void Instance_KeyEvent_10(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_10( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_8(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 1
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_8;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_8( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_14(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 1
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_14;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_14( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 1
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_18( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_21(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 1
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_21;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_21( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_24(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 1
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_24;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_24( );
   }
   
   void uScriptAct_Toggle_OnOut_81(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_81( );
   }
   
   void uScriptAct_Toggle_OffOut_81(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_81( );
   }
   
   void uScriptAct_Toggle_ToggleOut_81(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_81( );
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyInt_KeyName_3 = local_Choise_stg_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyInt_uScriptAct_GetPreferenceKeyInt_3.In(logic_uScriptAct_GetPreferenceKeyInt_KeyName_3, logic_uScriptAct_GetPreferenceKeyInt_DefaultValue_3, out logic_uScriptAct_GetPreferenceKeyInt_Value_3);
      local_Stg_int_System_Int32 = logic_uScriptAct_GetPreferenceKeyInt_Value_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPreferenceKeyInt_uScriptAct_GetPreferenceKeyInt_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_6()
   {
      {
         {
         }
         {
            logic_uScriptCon_CompareInt_B_6 = local_Stg_int_System_Int32;
            
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_6.In(logic_uScriptCon_CompareInt_A_6, logic_uScriptCon_CompareInt_B_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_6.EqualTo;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_6.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
      if ( test_1 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_FinishedSpawning_8()
   {
      Relay_In_30();
   }
   
   void Relay_In_8()
   {
      {
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_8 = _000_StageRoot_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_8.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_8, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_8, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_8, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_8, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_8, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_8, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_8, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_8, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_8);
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_8;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_KeyEvent_10()
   {
      Relay_In_11();
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_11 = local_12_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_11.In(logic_uScriptAct_OnInputEventFilter_KeyCode_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_13()
   {
      {
         {
         }
         {
            logic_uScriptCon_CompareInt_B_13 = local_Stg_int_System_Int32;
            
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13.In(logic_uScriptCon_CompareInt_A_13, logic_uScriptCon_CompareInt_B_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13.EqualTo;
      bool test_2 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_13.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
      if ( test_1 == true )
      {
         Relay_In_18();
      }
      if ( test_2 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_FinishedSpawning_14()
   {
      Relay_In_30();
   }
   
   void Relay_In_14()
   {
      {
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_14 = _000_StageRoot_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_14.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_14, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_14, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_14, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_14, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_14, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_14, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_14, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_14, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_14);
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_14;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_FinishedSpawning_18()
   {
      Relay_In_30();
   }
   
   void Relay_In_18()
   {
      {
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_18 = _000_StageRoot_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_18, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_18, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_18, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_18, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_18);
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_19()
   {
      {
         {
         }
         {
            logic_uScriptCon_CompareInt_B_19 = local_Stg_int_System_Int32;
            
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_19.In(logic_uScriptCon_CompareInt_A_19, logic_uScriptCon_CompareInt_B_19);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_19.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_19.EqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
      if ( test_1 == true )
      {
         Relay_In_24();
      }
   }
   
   void Relay_FinishedSpawning_21()
   {
      Relay_In_30();
   }
   
   void Relay_In_21()
   {
      {
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_21 = _000_StageRoot_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_21.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_21, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_21, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_21, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_21, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_21, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_21, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_21, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_21, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_21);
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_21;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_FinishedSpawning_24()
   {
      Relay_In_30();
   }
   
   void Relay_In_24()
   {
      {
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( _000_StageRoot_Obj_previous != _000_StageRoot_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  _000_StageRoot_Obj_previous = _000_StageRoot_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_24 = _000_StageRoot_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_24.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_24, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_24, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_24, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_24, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_24, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_24, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_24, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_24, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_24);
      local_Main_Stage_UnityEngine_GameObject = logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_24;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Main_Stage_UnityEngine_GameObject_previous != local_Main_Stage_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Main_Stage_UnityEngine_GameObject_previous = local_Main_Stage_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_29 = property_height_Value_Detox_ScriptEditor_Parameter_height_Value_28_Get_Refresh( );
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
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_29.In(logic_uScriptAct_FloatToString_Target_29, logic_uScriptAct_FloatToString_StandardFormat_29, logic_uScriptAct_FloatToString_CustomFormat_29, logic_uScriptAct_FloatToString_CustomCulture_29, out logic_uScriptAct_FloatToString_Result_29);
      property_text_Detox_ScriptEditor_Parameter_text_31 = logic_uScriptAct_FloatToString_Result_29;
      property_text_Detox_ScriptEditor_Parameter_text_31_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_29.Out;
      
      if ( test_0 == true )
      {
         Relay_TurnOn_81();
      }
   }
   
   void Relay_In_30()
   {
      {
         {
            logic_uScriptAct_SetString_Value_30 = property_Stage_Name_Detox_ScriptEditor_Parameter_Stage_Name_25_Get_Refresh( );
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
      logic_uScriptAct_SetString_uScriptAct_SetString_30.In(logic_uScriptAct_SetString_Value_30, logic_uScriptAct_SetString_ToUpperCase_30, logic_uScriptAct_SetString_ToLowerCase_30, logic_uScriptAct_SetString_TrimWhitespace_30, out logic_uScriptAct_SetString_Target_30);
      property_text_Detox_ScriptEditor_Parameter_text_26 = logic_uScriptAct_SetString_Target_30;
      property_text_Detox_ScriptEditor_Parameter_text_26_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_30.Out;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_OnOut_81()
   {
   }
   
   void Relay_OffOut_81()
   {
   }
   
   void Relay_ToggleOut_81()
   {
   }
   
   void Relay_TurnOn_81()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( PlayerRoot_previous != PlayerRoot || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  PlayerRoot_previous = PlayerRoot;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_81.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_81, index + 1);
            }
            logic_uScriptAct_Toggle_Target_81[ index++ ] = PlayerRoot;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.TurnOn(logic_uScriptAct_Toggle_Target_81, logic_uScriptAct_Toggle_IgnoreChildren_81);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_TurnOff_81()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( PlayerRoot_previous != PlayerRoot || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  PlayerRoot_previous = PlayerRoot;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_81.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_81, index + 1);
            }
            logic_uScriptAct_Toggle_Target_81[ index++ ] = PlayerRoot;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.TurnOff(logic_uScriptAct_Toggle_Target_81, logic_uScriptAct_Toggle_IgnoreChildren_81);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_81()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( PlayerRoot_previous != PlayerRoot || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  PlayerRoot_previous = PlayerRoot;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_81.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_81, index + 1);
            }
            logic_uScriptAct_Toggle_Target_81[ index++ ] = PlayerRoot;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_81.Toggle(logic_uScriptAct_Toggle_Target_81, logic_uScriptAct_Toggle_IgnoreChildren_81);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
