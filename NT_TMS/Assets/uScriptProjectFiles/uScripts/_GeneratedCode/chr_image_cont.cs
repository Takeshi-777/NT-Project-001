//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class chr_image_cont : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Image_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Image_obj_previous = null;
   UnityEngine.GameObject local_3_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_3_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_1 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_1 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_1 = true;
   bool logic_uScriptCon_CompareBool_False_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_4 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_4 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_4 = new Vector3( (float)1, (float)1, (float)1 );
   bool logic_uScriptAct_SetGameObjectScale_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_5 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_5 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_5 = new Vector3( (float)-1, (float)1, (float)1 );
   bool logic_uScriptAct_SetGameObjectScale_Out_5 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   System.Boolean property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_2 = (bool) false;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Boolean property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_2_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (local_3_UnityEngine_GameObject != null)
      {
         component = local_3_UnityEngine_GameObject.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jump_Vector;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_2_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (local_3_UnityEngine_GameObject != null)
      {
         component = local_3_UnityEngine_GameObject.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jump_Vector = property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_2;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_3_UnityEngine_GameObject = GameObject.Find( "Player_root" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Image_obj_previous != Image_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Image_obj_previous = Image_obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Image_obj_previous != Image_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Image_obj_previous = Image_obj;
         
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
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_1.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_4.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_5.SetParent(g);
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
   
   void Relay_OnUpdate_0()
   {
      Relay_In_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_1 = property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_2_Get_Refresh( );
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_1.In(logic_uScriptCon_CompareBool_Bool_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_1.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_1.False;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
      if ( test_1 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Image_obj_previous != Image_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Image_obj_previous = Image_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectScale_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_4, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_4[ index++ ] = Image_obj;
            
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_4.In(logic_uScriptAct_SetGameObjectScale_Target_4, logic_uScriptAct_SetGameObjectScale_Scale_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_5()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Image_obj_previous != Image_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Image_obj_previous = Image_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectScale_Target_5.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_5, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_5[ index++ ] = Image_obj;
            
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_5.In(logic_uScriptAct_SetGameObjectScale_Target_5, logic_uScriptAct_SetGameObjectScale_Scale_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
