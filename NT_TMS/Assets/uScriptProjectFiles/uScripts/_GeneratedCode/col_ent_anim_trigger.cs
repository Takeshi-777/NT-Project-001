//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class col_ent_anim_trigger : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _Score_Obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _Score_Obj_previous = null;
   public UnityEngine.GameObject Col_Obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Col_Obj_previous = null;
   System.Single local_6_System_Single = (float) 2;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterTrigger logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2 = new uScriptAct_AnimatorSetParameterTrigger( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterTrigger_Target_2 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterTrigger_Name_2 = "end";
   bool logic_uScriptAct_AnimatorSetParameterTrigger_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_4 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_4 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_4 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_4 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_4 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_4 = false;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_5 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_5 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_5 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_5 = true;
   bool logic_uScriptAct_Delay_AfterDelay_5 = true;
   bool logic_uScriptAct_Delay_Stopped_5 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_5 = false;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_8 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_B_8 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_8;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_8;
   bool logic_uScriptAct_AddInt_v2_Out_8 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_15 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_15 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_15 = (int) 1;
   bool logic_uScriptCon_CompareInt_GreaterThan_15 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_15 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_15 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_15 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_15 = true;
   bool logic_uScriptCon_CompareInt_LessThan_15 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_16 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_16 = (int) 3;
   bool logic_uScriptCon_CompareInt_GreaterThan_16 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_16 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_16 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_16 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_16 = true;
   bool logic_uScriptCon_CompareInt_LessThan_16 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_17 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_17 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_B_17 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_17;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_17;
   bool logic_uScriptAct_AddInt_v2_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_18 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_18 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_B_18 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_18;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_18;
   bool logic_uScriptAct_AddInt_v2_Out_18 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_20 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_20 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_20 = (int) 5;
   bool logic_uScriptCon_CompareInt_GreaterThan_20 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_20 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_20 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_20 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_20 = true;
   bool logic_uScriptCon_CompareInt_LessThan_20 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_21 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_21 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_B_21 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_21;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_21;
   bool logic_uScriptAct_AddInt_v2_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_23 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_23 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_B_23 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_23;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_23;
   bool logic_uScriptAct_AddInt_v2_Out_23 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_55 = default(UnityEngine.GameObject);
   
   //property nodes
   System.Int32 property__ID_Detox_ScriptEditor_Parameter__ID_1 = (int) 0;
   System.Int32 property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10 = (int) 0;
   System.Int32 property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11 = (int) 0;
   System.Int32 property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12 = (int) 0;
   System.Int32 property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13 = (int) 0;
   System.Int32 property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14 = (int) 0;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Int32 property__ID_Detox_ScriptEditor_Parameter__ID_1_Get_Refresh( )
   {
      Item_Paream_Component component = null;
      if (Col_Obj != null)
      {
         component = Col_Obj.GetComponent<Item_Paream_Component>();
      }
      if ( null != component )
      {
         return component._ID;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property__ID_Detox_ScriptEditor_Parameter__ID_1_Set_Refresh( )
   {
      Item_Paream_Component component = null;
      if (Col_Obj != null)
      {
         component = Col_Obj.GetComponent<Item_Paream_Component>();
      }
      if ( null != component )
      {
         component._ID = property__ID_Detox_ScriptEditor_Parameter__ID_1;
      }
   }
   
   System.Int32 property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10_Get_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         return component.ID_001_Count;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10_Set_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         component.ID_001_Count = property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10;
      }
   }
   
   System.Int32 property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11_Get_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         return component.ID_002_Count;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11_Set_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         component.ID_002_Count = property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11;
      }
   }
   
   System.Int32 property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12_Get_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         return component.ID_003_Count;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12_Set_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         component.ID_003_Count = property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12;
      }
   }
   
   System.Int32 property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13_Get_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         return component.ID_004_Count;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13_Set_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         component.ID_004_Count = property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13;
      }
   }
   
   System.Int32 property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14_Get_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         return component.ID_005_Count;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14_Set_Refresh( )
   {
      Stage_Score_Recorder_Component component = null;
      if (_Score_Obj != null)
      {
         component = _Score_Obj.GetComponent<Stage_Score_Recorder_Component>();
      }
      if ( null != component )
      {
         component.ID_005_Count = property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_Obj_previous != Col_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_Obj_previous )
         {
            {
               uScript_Trigger2D component = Col_Obj_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                  component.OnExitTrigger -= Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
               }
            }
         }
         
         Col_Obj_previous = Col_Obj;
         
         //setup new listeners
         if ( null != Col_Obj )
         {
            {
               uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_Obj.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                  component.OnExitTrigger += Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Score_Obj_previous != _Score_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _Score_Obj_previous = _Score_Obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_Obj_previous != Col_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_Obj_previous )
         {
            {
               uScript_Trigger2D component = Col_Obj_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                  component.OnExitTrigger -= Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
               }
            }
         }
         
         Col_Obj_previous = Col_Obj;
         
         //setup new listeners
         if ( null != Col_Obj )
         {
            {
               uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_Obj.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                  component.OnExitTrigger += Instance_OnExitTrigger_55;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _Score_Obj_previous != _Score_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _Score_Obj_previous = _Score_Obj;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Col_Obj )
      {
         {
            uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
               component.OnExitTrigger -= Instance_OnExitTrigger_55;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_4.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_5.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_15.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_17.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_18.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_20.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_21.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_23.SetParent(g);
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
      
      if (true == logic_uScriptAct_Destroy_WaitOneTick_4)
      {
         Relay_WaitOneTick_4();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_5)
      {
         Relay_DrivenDelay_5();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnEnterTrigger_55(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_55( );
   }
   
   void Instance_OnExitTrigger_55(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_55( );
   }
   
   void Instance_WhileInsideTrigger_55(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_55 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_55( );
   }
   
   void Relay_In_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Col_Obj_previous != Col_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  if ( null != Col_Obj_previous )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj_previous.GetComponent<uScript_Trigger2D>();
                        if ( null != component )
                        {
                           component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                           component.OnExitTrigger -= Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
                  
                  Col_Obj_previous = Col_Obj;
                  
                  //setup new listeners
                  if ( null != Col_Obj )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
                        if ( null == component )
                        {
                           component = Col_Obj.AddComponent<uScript_Trigger2D>();
                        }
                        if ( null != component )
                        {
                           component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                           component.OnExitTrigger += Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterTrigger_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterTrigger_Target_2, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterTrigger_Target_2[ index++ ] = Col_Obj;
            
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.In(logic_uScriptAct_AnimatorSetParameterTrigger_Target_2, logic_uScriptAct_AnimatorSetParameterTrigger_Name_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Col_Obj_previous != Col_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  if ( null != Col_Obj_previous )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj_previous.GetComponent<uScript_Trigger2D>();
                        if ( null != component )
                        {
                           component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                           component.OnExitTrigger -= Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
                  
                  Col_Obj_previous = Col_Obj;
                  
                  //setup new listeners
                  if ( null != Col_Obj )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
                        if ( null == component )
                        {
                           component = Col_Obj.AddComponent<uScript_Trigger2D>();
                        }
                        if ( null != component )
                        {
                           component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                           component.OnExitTrigger += Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
               }
            }
            if ( logic_uScriptAct_Destroy_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_4, index + 1);
            }
            logic_uScriptAct_Destroy_Target_4[ index++ ] = Col_Obj;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_uScriptAct_Destroy_4.In(logic_uScriptAct_Destroy_Target_4, logic_uScriptAct_Destroy_DelayTime_4);
      logic_uScriptAct_Destroy_WaitOneTick_4 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_WaitOneTick_4( )
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Col_Obj_previous != Col_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  if ( null != Col_Obj_previous )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj_previous.GetComponent<uScript_Trigger2D>();
                        if ( null != component )
                        {
                           component.OnEnterTrigger -= Instance_OnEnterTrigger_55;
                           component.OnExitTrigger -= Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger -= Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
                  
                  Col_Obj_previous = Col_Obj;
                  
                  //setup new listeners
                  if ( null != Col_Obj )
                  {
                     {
                        uScript_Trigger2D component = Col_Obj.GetComponent<uScript_Trigger2D>();
                        if ( null == component )
                        {
                           component = Col_Obj.AddComponent<uScript_Trigger2D>();
                        }
                        if ( null != component )
                        {
                           component.OnEnterTrigger += Instance_OnEnterTrigger_55;
                           component.OnExitTrigger += Instance_OnExitTrigger_55;
                           component.WhileInsideTrigger += Instance_WhileInsideTrigger_55;
                        }
                     }
                  }
               }
            }
            if ( logic_uScriptAct_Destroy_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_4, index + 1);
            }
            logic_uScriptAct_Destroy_Target_4[ index++ ] = Col_Obj;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_WaitOneTick_4 = logic_uScriptAct_Destroy_uScriptAct_Destroy_4.WaitOneTick();
      if ( true == logic_uScriptAct_Destroy_WaitOneTick_4 )
      {
      }
   }
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_5 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_5.In(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
      logic_uScriptAct_Delay_DrivenDelay_5 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_Stop_5()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_5 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_5.Stop(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
      logic_uScriptAct_Delay_DrivenDelay_5 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_DrivenDelay_5( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_5 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_5 = logic_uScriptAct_Delay_uScriptAct_Delay_5.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_5 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay == true )
         {
            Relay_In_4();
         }
      }
   }
   void Relay_In_8()
   {
      {
         {
         }
         {
            logic_uScriptAct_AddInt_v2_B_8 = property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.In(logic_uScriptAct_AddInt_v2_A_8, logic_uScriptAct_AddInt_v2_B_8, out logic_uScriptAct_AddInt_v2_IntResult_8, out logic_uScriptAct_AddInt_v2_FloatResult_8);
      property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10 = logic_uScriptAct_AddInt_v2_IntResult_8;
      property_ID_001_Count_Detox_ScriptEditor_Parameter_ID_001_Count_10_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_15()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_15 = property__ID_Detox_ScriptEditor_Parameter__ID_1_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_15.In(logic_uScriptCon_CompareInt_A_15, logic_uScriptCon_CompareInt_B_15);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_15.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_15.EqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
      if ( test_1 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_16 = property__ID_Detox_ScriptEditor_Parameter__ID_1_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16.In(logic_uScriptCon_CompareInt_A_16, logic_uScriptCon_CompareInt_B_16);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16.EqualTo;
      bool test_2 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_16.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
      if ( test_1 == true )
      {
         Relay_In_18();
      }
      if ( test_2 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
         }
         {
            logic_uScriptAct_AddInt_v2_B_17 = property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_17.In(logic_uScriptAct_AddInt_v2_A_17, logic_uScriptAct_AddInt_v2_B_17, out logic_uScriptAct_AddInt_v2_IntResult_17, out logic_uScriptAct_AddInt_v2_FloatResult_17);
      property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11 = logic_uScriptAct_AddInt_v2_IntResult_17;
      property_ID_002_Count_Detox_ScriptEditor_Parameter_ID_002_Count_11_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_18()
   {
      {
         {
         }
         {
            logic_uScriptAct_AddInt_v2_B_18 = property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_18.In(logic_uScriptAct_AddInt_v2_A_18, logic_uScriptAct_AddInt_v2_B_18, out logic_uScriptAct_AddInt_v2_IntResult_18, out logic_uScriptAct_AddInt_v2_FloatResult_18);
      property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12 = logic_uScriptAct_AddInt_v2_IntResult_18;
      property_ID_003_Count_Detox_ScriptEditor_Parameter_ID_003_Count_12_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_20()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_20 = property__ID_Detox_ScriptEditor_Parameter__ID_1_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_20.In(logic_uScriptCon_CompareInt_A_20, logic_uScriptCon_CompareInt_B_20);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_20.EqualTo;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_20.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_23();
      }
      if ( test_1 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_In_21()
   {
      {
         {
         }
         {
            logic_uScriptAct_AddInt_v2_B_21 = property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_21.In(logic_uScriptAct_AddInt_v2_A_21, logic_uScriptAct_AddInt_v2_B_21, out logic_uScriptAct_AddInt_v2_IntResult_21, out logic_uScriptAct_AddInt_v2_FloatResult_21);
      property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13 = logic_uScriptAct_AddInt_v2_IntResult_21;
      property_ID_004_Count_Detox_ScriptEditor_Parameter_ID_004_Count_13_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_23()
   {
      {
         {
         }
         {
            logic_uScriptAct_AddInt_v2_B_23 = property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_23.In(logic_uScriptAct_AddInt_v2_A_23, logic_uScriptAct_AddInt_v2_B_23, out logic_uScriptAct_AddInt_v2_IntResult_23, out logic_uScriptAct_AddInt_v2_FloatResult_23);
      property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14 = logic_uScriptAct_AddInt_v2_IntResult_23;
      property_ID_005_Count_Detox_ScriptEditor_Parameter_ID_005_Count_14_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_55()
   {
      Relay_In_2();
      Relay_In_15();
   }
   
   void Relay_OnExitTrigger_55()
   {
   }
   
   void Relay_WhileInsideTrigger_55()
   {
   }
   
}
