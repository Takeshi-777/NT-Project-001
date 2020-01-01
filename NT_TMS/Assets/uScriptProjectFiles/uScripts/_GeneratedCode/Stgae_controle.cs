//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Stgae_controle : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Cam_world = default(UnityEngine.GameObject);
   UnityEngine.GameObject Cam_world_previous = null;
   public System.Single deadline_Y = (float) 570;
   UnityEngine.GameObject local_1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_1_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector2 local_11_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   UnityEngine.GameObject local_17_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_17_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector2 local_19_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   UnityEngine.GameObject local_20_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_20_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_29_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_29_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector2 local_3_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   System.Single local_guide_y_pos_System_Single = (float) 0;
   System.Single local_player_y_pos_System_Single = (float) 0;
   public UnityEngine.GameObject source = default(UnityEngine.GameObject);
   UnityEngine.GameObject source_previous = null;
   public System.Single Transition_Time = (float) 0.2;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetRectTransformPosition2D logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2 = new uScriptAct_GetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRectTransformPosition2D_Target_2 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_GetRectTransformPosition2D_Position_2;
   bool logic_uScriptAct_GetRectTransformPosition2D_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector2 logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_4 = new uScriptAct_GetComponentsVector2( );
   UnityEngine.Vector2 logic_uScriptAct_GetComponentsVector2_InputVector2_4 = new Vector2( );
   System.Single logic_uScriptAct_GetComponentsVector2_X_4;
   System.Single logic_uScriptAct_GetComponentsVector2_Y_4;
   bool logic_uScriptAct_GetComponentsVector2_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_6 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_6 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_6 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_6 = (float) 0;
   bool logic_uScriptAct_MoveToLocationRelative_Out_6 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRectTransformPosition2D logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_10 = new uScriptAct_SetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_SetRectTransformPosition2D_Target_10 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_SetRectTransformPosition2D_Position_10 = new Vector2( );
   bool logic_uScriptAct_SetRectTransformPosition2D_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_12 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_12 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_12 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_12;
   bool logic_uScriptAct_SetComponentsVector2_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_14 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_14 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_14 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_14 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_14 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_14 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_14 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_14 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_14 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRectTransformPosition2D logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16 = new uScriptAct_GetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRectTransformPosition2D_Target_16 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_GetRectTransformPosition2D_Position_16;
   bool logic_uScriptAct_GetRectTransformPosition2D_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector2 logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_18 = new uScriptAct_GetComponentsVector2( );
   UnityEngine.Vector2 logic_uScriptAct_GetComponentsVector2_InputVector2_18 = new Vector2( );
   System.Single logic_uScriptAct_GetComponentsVector2_X_18;
   System.Single logic_uScriptAct_GetComponentsVector2_Y_18;
   bool logic_uScriptAct_GetComponentsVector2_Out_18 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_24 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_24 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_24 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_24 = (float) 0;
   bool logic_uScriptAct_MoveToLocationRelative_Out_24 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_24 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_25 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_25 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_25 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_25 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_25 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_25 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_25 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_25 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_25 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationRelative logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28 = new uScriptAct_MoveToLocationRelative( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationRelative_targetArray_28 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationRelative_location_28 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_MoveToLocationRelative_source_28 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_MoveToLocationRelative_totalTime_28 = (float) 0;
   bool logic_uScriptAct_MoveToLocationRelative_Out_28 = true;
   bool logic_uScriptAct_MoveToLocationRelative_Cancelled_28 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_21 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_1_UnityEngine_GameObject = GameObject.Find( "Player_root" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == source || false == m_RegisteredForEvents )
      {
         source = GameObject.Find( "Guide_cam" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( source_previous != source || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         source_previous = source;
         
         //setup new listeners
      }
      if ( null == local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_17_UnityEngine_GameObject = GameObject.Find( "Guide_cam" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_20_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_20_UnityEngine_GameObject = GameObject.Find( "Player_root" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_20_UnityEngine_GameObject_previous != local_20_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_20_UnityEngine_GameObject_previous = local_20_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Cam_world_previous = Cam_world;
         
         //setup new listeners
      }
      if ( null == local_29_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_29_UnityEngine_GameObject = GameObject.Find( "Cam_reset_pos" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_29_UnityEngine_GameObject_previous != local_29_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_29_UnityEngine_GameObject_previous = local_29_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( source_previous != source || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         source_previous = source;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_20_UnityEngine_GameObject_previous != local_20_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_20_UnityEngine_GameObject_previous = local_20_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Cam_world_previous = Cam_world;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_29_UnityEngine_GameObject_previous != local_29_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_29_UnityEngine_GameObject_previous = local_29_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_21 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_21 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_21 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_21.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_21;
                  component.OnLateUpdate += Instance_OnLateUpdate_21;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_21;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_21 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_21;
               component.OnLateUpdate -= Instance_OnLateUpdate_21;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_21;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.SetParent(g);
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_4.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.SetParent(g);
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_10.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_12.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_14.SetParent(g);
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16.SetParent(g);
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_18.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_25.SetParent(g);
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Finished += uScriptAct_MoveToLocationRelative_Finished_6;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.Finished += uScriptAct_MoveToLocationRelative_Finished_24;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Finished += uScriptAct_MoveToLocationRelative_Finished_28;
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
      
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.Update( );
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Finished -= uScriptAct_MoveToLocationRelative_Finished_6;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.Finished -= uScriptAct_MoveToLocationRelative_Finished_24;
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Finished -= uScriptAct_MoveToLocationRelative_Finished_28;
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Instance_OnUpdate_21(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_21( );
   }
   
   void Instance_OnLateUpdate_21(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_21( );
   }
   
   void Instance_OnFixedUpdate_21(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_21( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_6( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_24(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_24( );
   }
   
   void uScriptAct_MoveToLocationRelative_Finished_28(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_28( );
   }
   
   void Relay_OnUpdate_0()
   {
      Relay_In_2();
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetRectTransformPosition2D_Target_2 = local_1_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.In(logic_uScriptAct_GetRectTransformPosition2D_Target_2, out logic_uScriptAct_GetRectTransformPosition2D_Position_2);
      local_3_UnityEngine_Vector2 = logic_uScriptAct_GetRectTransformPosition2D_Position_2;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector2_InputVector2_4 = local_3_UnityEngine_Vector2;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_4.In(logic_uScriptAct_GetComponentsVector2_InputVector2_4, out logic_uScriptAct_GetComponentsVector2_X_4, out logic_uScriptAct_GetComponentsVector2_Y_4);
      local_player_y_pos_System_Single = logic_uScriptAct_GetComponentsVector2_Y_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_Finished_6()
   {
   }
   
   void Relay_In_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_6, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_6[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( source_previous != source || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  source_previous = source;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_6 = source;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_6 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.In(logic_uScriptAct_MoveToLocationRelative_targetArray_6, logic_uScriptAct_MoveToLocationRelative_location_6, logic_uScriptAct_MoveToLocationRelative_source_6, logic_uScriptAct_MoveToLocationRelative_totalTime_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_6, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_6[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( source_previous != source || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  source_previous = source;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_6 = source;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_6 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_6.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_6, logic_uScriptAct_MoveToLocationRelative_location_6, logic_uScriptAct_MoveToLocationRelative_source_6, logic_uScriptAct_MoveToLocationRelative_totalTime_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_10()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( source_previous != source || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  source_previous = source;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SetRectTransformPosition2D_Target_10 = source;
            
         }
         {
            logic_uScriptAct_SetRectTransformPosition2D_Position_10 = local_11_UnityEngine_Vector2;
            
         }
      }
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_10.In(logic_uScriptAct_SetRectTransformPosition2D_Target_10, logic_uScriptAct_SetRectTransformPosition2D_Position_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_12()
   {
      {
         {
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_12 = local_player_y_pos_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_12.In(logic_uScriptAct_SetComponentsVector2_X_12, logic_uScriptAct_SetComponentsVector2_Y_12, out logic_uScriptAct_SetComponentsVector2_OutputVector2_12);
      local_11_UnityEngine_Vector2 = logic_uScriptAct_SetComponentsVector2_OutputVector2_12;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_12.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_14()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_14 = local_player_y_pos_System_Single;
            
         }
         {
            logic_uScriptCon_CompareFloat_B_14 = local_guide_y_pos_System_Single;
            
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_14.In(logic_uScriptCon_CompareFloat_A_14, logic_uScriptCon_CompareFloat_B_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_14.GreaterThan;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_17_UnityEngine_GameObject_previous != local_17_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_17_UnityEngine_GameObject_previous = local_17_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetRectTransformPosition2D_Target_16 = local_17_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16.In(logic_uScriptAct_GetRectTransformPosition2D_Target_16, out logic_uScriptAct_GetRectTransformPosition2D_Position_16);
      local_19_UnityEngine_Vector2 = logic_uScriptAct_GetRectTransformPosition2D_Position_16;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16.Out;
      
      if ( test_0 == true )
      {
         Relay_In_18();
      }
   }
   
   void Relay_In_18()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector2_InputVector2_18 = local_19_UnityEngine_Vector2;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_18.In(logic_uScriptAct_GetComponentsVector2_InputVector2_18, out logic_uScriptAct_GetComponentsVector2_X_18, out logic_uScriptAct_GetComponentsVector2_Y_18);
      local_guide_y_pos_System_Single = logic_uScriptAct_GetComponentsVector2_Y_18;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_18.Out;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
   }
   
   void Relay_OnUpdate_21()
   {
      Relay_In_25();
   }
   
   void Relay_OnLateUpdate_21()
   {
   }
   
   void Relay_OnFixedUpdate_21()
   {
   }
   
   void Relay_Finished_24()
   {
   }
   
   void Relay_In_24()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_24.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_24, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_24[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_20_UnityEngine_GameObject_previous != local_20_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_20_UnityEngine_GameObject_previous = local_20_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_24 = local_20_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_24 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.In(logic_uScriptAct_MoveToLocationRelative_targetArray_24, logic_uScriptAct_MoveToLocationRelative_location_24, logic_uScriptAct_MoveToLocationRelative_source_24, logic_uScriptAct_MoveToLocationRelative_totalTime_24);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_24()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_24.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_24, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_24[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_20_UnityEngine_GameObject_previous != local_20_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_20_UnityEngine_GameObject_previous = local_20_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_24 = local_20_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_24 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_24.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_24, logic_uScriptAct_MoveToLocationRelative_location_24, logic_uScriptAct_MoveToLocationRelative_source_24, logic_uScriptAct_MoveToLocationRelative_totalTime_24);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_25()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_25 = deadline_Y;
            
         }
         {
            logic_uScriptCon_CompareFloat_B_25 = local_player_y_pos_System_Single;
            
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_25.In(logic_uScriptCon_CompareFloat_A_25, logic_uScriptCon_CompareFloat_B_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_25.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_25.LessThan;
      
      if ( test_0 == true )
      {
         Relay_Cancel_24();
         Relay_In_28();
      }
      if ( test_1 == true )
      {
         Relay_In_24();
         Relay_Cancel_28();
      }
   }
   
   void Relay_Finished_28()
   {
   }
   
   void Relay_In_28()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_28.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_28, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_28[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_29_UnityEngine_GameObject_previous != local_29_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_29_UnityEngine_GameObject_previous = local_29_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_28 = local_29_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_28 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.In(logic_uScriptAct_MoveToLocationRelative_targetArray_28, logic_uScriptAct_MoveToLocationRelative_location_28, logic_uScriptAct_MoveToLocationRelative_source_28, logic_uScriptAct_MoveToLocationRelative_totalTime_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_28()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Cam_world_previous != Cam_world || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Cam_world_previous = Cam_world;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_MoveToLocationRelative_targetArray_28.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocationRelative_targetArray_28, index + 1);
            }
            logic_uScriptAct_MoveToLocationRelative_targetArray_28[ index++ ] = Cam_world;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_29_UnityEngine_GameObject_previous != local_29_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_29_UnityEngine_GameObject_previous = local_29_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_MoveToLocationRelative_source_28 = local_29_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_MoveToLocationRelative_totalTime_28 = Transition_Time;
            
         }
      }
      logic_uScriptAct_MoveToLocationRelative_uScriptAct_MoveToLocationRelative_28.Cancel(logic_uScriptAct_MoveToLocationRelative_targetArray_28, logic_uScriptAct_MoveToLocationRelative_location_28, logic_uScriptAct_MoveToLocationRelative_source_28, logic_uScriptAct_MoveToLocationRelative_totalTime_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
