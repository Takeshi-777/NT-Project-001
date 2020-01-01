//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Home_Button : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Boolean BtnSet_Bool = (bool) false;
   public UnityEngine.GameObject Button_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Button_obj_previous = null;
   UnityEngine.GameObject local_6_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_6_UnityEngine_GameObject_previous = null;
   System.String local_7_System_String = "Chage";
   public UnityEngine.GameObject send_sigobj = default(UnityEngine.GameObject);
   UnityEngine.GameObject send_sigobj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_2 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_2;
   bool logic_uScriptAct_SetBool_Out_2 = true;
   bool logic_uScriptAct_SetBool_SetTrue_2 = true;
   bool logic_uScriptAct_SetBool_SetFalse_2 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_3 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_3 = true;
   bool logic_uScriptCon_CompareBool_False_3 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_9 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_9 = "";
   System.Object[] logic_uScriptAct_Log_Target_9 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_9 = "";
   bool logic_uScriptAct_Log_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SendCustomEvent logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_10 = new uScriptAct_SendCustomEvent( );
   System.String logic_uScriptAct_SendCustomEvent_EventName_10 = "";
   uScriptCustomEvent.SendGroup logic_uScriptAct_SendCustomEvent_sendGroup_10 = uScriptCustomEvent.SendGroup.All;
   UnityEngine.GameObject logic_uScriptAct_SendCustomEvent_EventSender_10 = default(UnityEngine.GameObject);
   bool logic_uScriptAct_SendCustomEvent_Out_10 = true;
   
   //event nodes
   
   //property nodes
   System.Boolean property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5 = (bool) false;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Boolean property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5_Get_Refresh( )
   {
      Home_SceneChange_Component component = null;
      if (local_6_UnityEngine_GameObject != null)
      {
         component = local_6_UnityEngine_GameObject.GetComponent<Home_SceneChange_Component>();
      }
      if ( null != component )
      {
         return component.ChoiseGameMode;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5_Set_Refresh( )
   {
      Home_SceneChange_Component component = null;
      if (local_6_UnityEngine_GameObject != null)
      {
         component = local_6_UnityEngine_GameObject.GetComponent<Home_SceneChange_Component>();
      }
      if ( null != component )
      {
         component.ChoiseGameMode = property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Button_obj_previous != Button_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Button_obj_previous )
         {
            {
               uScript_Button component = Button_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         Button_obj_previous = Button_obj;
         
         //setup new listeners
         if ( null != Button_obj )
         {
            {
               uScript_Button component = Button_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Button_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
      if ( null == local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_6_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( send_sigobj_previous != send_sigobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         send_sigobj_previous = send_sigobj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Button_obj_previous != Button_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Button_obj_previous )
         {
            {
               uScript_Button component = Button_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         Button_obj_previous = Button_obj;
         
         //setup new listeners
         if ( null != Button_obj )
         {
            {
               uScript_Button component = Button_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Button_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( send_sigobj_previous != send_sigobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         send_sigobj_previous = send_sigobj;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Button_obj )
      {
         {
            uScript_Button component = Button_obj.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_0;
               component.OnButtonDown -= Instance_OnButtonDown_0;
               component.OnButtonUp -= Instance_OnButtonUp_0;
               component.OnButtonEnter -= Instance_OnButtonEnter_0;
               component.OnButtonExit -= Instance_OnButtonExit_0;
               component.OnButtonDrag -= Instance_OnButtonDrag_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetBool_uScriptAct_SetBool_2.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_9.SetParent(g);
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_10.SetParent(g);
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
   
   void Instance_OnButtonClick_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_0( );
   }
   
   void Instance_OnButtonDown_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_0( );
   }
   
   void Instance_OnButtonUp_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_0( );
   }
   
   void Instance_OnButtonEnter_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_0( );
   }
   
   void Instance_OnButtonExit_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_0( );
   }
   
   void Instance_OnButtonDrag_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_0( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
   }
   
   void Relay_OnButtonUp_0()
   {
      Relay_In_3();
      Relay_SendCustomEvent_10();
   }
   
   void Relay_OnButtonEnter_0()
   {
   }
   
   void Relay_OnButtonExit_0()
   {
   }
   
   void Relay_OnButtonDrag_0()
   {
   }
   
   void Relay_True_2()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_2.True(out logic_uScriptAct_SetBool_Target_2);
      property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5 = logic_uScriptAct_SetBool_Target_2;
      property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_2()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_2.False(out logic_uScriptAct_SetBool_Target_2);
      property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5 = logic_uScriptAct_SetBool_Target_2;
      property_ChoiseGameMode_Detox_ScriptEditor_Parameter_ChoiseGameMode_5_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_3 = BtnSet_Bool;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.In(logic_uScriptCon_CompareBool_Bool_3);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.False;
      
      if ( test_0 == true )
      {
         Relay_True_2();
      }
      if ( test_1 == true )
      {
         Relay_False_2();
      }
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
            logic_uScriptAct_Log_Target_9[ index++ ] = local_7_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_9.In(logic_uScriptAct_Log_Prefix_9, logic_uScriptAct_Log_Target_9, logic_uScriptAct_Log_Postfix_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_SendCustomEvent_10()
   {
      {
         {
            logic_uScriptAct_SendCustomEvent_EventName_10 = local_7_System_String;
            
         }
         {
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( send_sigobj_previous != send_sigobj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  send_sigobj_previous = send_sigobj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SendCustomEvent_EventSender_10 = send_sigobj;
            
         }
      }
      logic_uScriptAct_SendCustomEvent_uScriptAct_SendCustomEvent_10.SendCustomEvent(logic_uScriptAct_SendCustomEvent_EventName_10, logic_uScriptAct_SendCustomEvent_sendGroup_10, logic_uScriptAct_SendCustomEvent_EventSender_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
