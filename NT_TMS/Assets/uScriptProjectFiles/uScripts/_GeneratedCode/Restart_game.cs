//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Restart_game : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Dead_col = default(UnityEngine.GameObject);
   UnityEngine.GameObject Dead_col_previous = null;
   public UnityEngine.GameObject Goal_col = default(UnityEngine.GameObject);
   UnityEngine.GameObject Goal_col_previous = null;
   public UnityEngine.Vector2 Guide_Cam_ResetPos = new Vector2( (float)0, (float)90 );
   UnityEngine.GameObject local_10_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_10_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_11_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_11_UnityEngine_GameObject_previous = null;
   System.String local_4_System_String = "reset";
   public UnityEngine.GameObject Main_Cam = default(UnityEngine.GameObject);
   UnityEngine.GameObject Main_Cam_previous = null;
   public UnityEngine.Vector2 Player_restart_pos = new Vector2( (float)320, (float)100 );
   public UnityEngine.GameObject prd_anim_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject prd_anim_obj_previous = null;
   public UnityEngine.GameObject ReSet_Button = default(UnityEngine.GameObject);
   UnityEngine.GameObject ReSet_Button_previous = null;
   public UnityEngine.GameObject ReSet_Button_02 = default(UnityEngine.GameObject);
   UnityEngine.GameObject ReSet_Button_02_previous = null;
   public System.Single Restart_Delay = (float) 0.5;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterTrigger logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2 = new uScriptAct_AnimatorSetParameterTrigger( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterTrigger_Target_2 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterTrigger_Name_2 = "";
   bool logic_uScriptAct_AnimatorSetParameterTrigger_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRectTransformPosition2D logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_5 = new uScriptAct_SetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_SetRectTransformPosition2D_Target_5 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_SetRectTransformPosition2D_Position_5 = new Vector2( );
   bool logic_uScriptAct_SetRectTransformPosition2D_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_6 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_6 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_6 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_6 = true;
   bool logic_uScriptAct_Delay_AfterDelay_6 = true;
   bool logic_uScriptAct_Delay_Stopped_6 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_6 = false;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_9 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_9 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_9 = new Vector3( (float)0, (float)0, (float)-50 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_9 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_9 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRectTransformPosition2D logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_12 = new uScriptAct_SetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_SetRectTransformPosition2D_Target_12 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_SetRectTransformPosition2D_Position_12 = new Vector2( );
   bool logic_uScriptAct_SetRectTransformPosition2D_Out_12 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_14 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_14 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_14 = "Clear";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_14 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_20 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_20;
   bool logic_uScriptAct_SetBool_Out_20 = true;
   bool logic_uScriptAct_SetBool_SetTrue_20 = true;
   bool logic_uScriptAct_SetBool_SetFalse_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_21 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_21;
   bool logic_uScriptAct_SetBool_Out_21 = true;
   bool logic_uScriptAct_SetBool_SetTrue_21 = true;
   bool logic_uScriptAct_SetBool_SetFalse_21 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_22 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_22 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_22 = "dead";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_22 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_22 = true;
   
   //event nodes
   
   //property nodes
   System.Boolean property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16 = (bool) false;
   System.Boolean property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17 = (bool) false;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Boolean property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Get_Refresh( )
   {
      UnityEngine.BoxCollider2D component = null;
      if (Goal_col != null)
      {
         component = Goal_col.GetComponent<UnityEngine.BoxCollider2D>();
      }
      if ( null != component )
      {
         return component.isTrigger;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Set_Refresh( )
   {
      UnityEngine.BoxCollider2D component = null;
      if (Goal_col != null)
      {
         component = Goal_col.GetComponent<UnityEngine.BoxCollider2D>();
      }
      if ( null != component )
      {
         component.isTrigger = property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16;
      }
   }
   
   System.Boolean property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Get_Refresh( )
   {
      UnityEngine.BoxCollider2D component = null;
      if (Dead_col != null)
      {
         component = Dead_col.GetComponent<UnityEngine.BoxCollider2D>();
      }
      if ( null != component )
      {
         return component.isTrigger;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Set_Refresh( )
   {
      UnityEngine.BoxCollider2D component = null;
      if (Dead_col != null)
      {
         component = Dead_col.GetComponent<UnityEngine.BoxCollider2D>();
      }
      if ( null != component )
      {
         component.isTrigger = property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( ReSet_Button_previous != ReSet_Button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != ReSet_Button_previous )
         {
            {
               uScript_Button component = ReSet_Button_previous.GetComponent<uScript_Button>();
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
         
         ReSet_Button_previous = ReSet_Button;
         
         //setup new listeners
         if ( null != ReSet_Button )
         {
            {
               uScript_Button component = ReSet_Button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = ReSet_Button.AddComponent<uScript_Button>();
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
      if ( prd_anim_obj_previous != prd_anim_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         prd_anim_obj_previous = prd_anim_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Main_Cam_previous != Main_Cam || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Main_Cam_previous = Main_Cam;
         
         //setup new listeners
      }
      if ( null == local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_10_UnityEngine_GameObject = GameObject.Find( "Guide_cam" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_11_UnityEngine_GameObject = GameObject.Find( "Player_root" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Goal_col_previous != Goal_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Goal_col_previous = Goal_col;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Dead_col_previous != Dead_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Dead_col_previous = Dead_col;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ReSet_Button_02_previous != ReSet_Button_02 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != ReSet_Button_02_previous )
         {
            {
               uScript_Button component = ReSet_Button_02_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_23;
                  component.OnButtonDown -= Instance_OnButtonDown_23;
                  component.OnButtonUp -= Instance_OnButtonUp_23;
                  component.OnButtonEnter -= Instance_OnButtonEnter_23;
                  component.OnButtonExit -= Instance_OnButtonExit_23;
                  component.OnButtonDrag -= Instance_OnButtonDrag_23;
               }
            }
         }
         
         ReSet_Button_02_previous = ReSet_Button_02;
         
         //setup new listeners
         if ( null != ReSet_Button_02 )
         {
            {
               uScript_Button component = ReSet_Button_02.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = ReSet_Button_02.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_23;
                  component.OnButtonDown += Instance_OnButtonDown_23;
                  component.OnButtonUp += Instance_OnButtonUp_23;
                  component.OnButtonEnter += Instance_OnButtonEnter_23;
                  component.OnButtonExit += Instance_OnButtonExit_23;
                  component.OnButtonDrag += Instance_OnButtonDrag_23;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( ReSet_Button_previous != ReSet_Button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != ReSet_Button_previous )
         {
            {
               uScript_Button component = ReSet_Button_previous.GetComponent<uScript_Button>();
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
         
         ReSet_Button_previous = ReSet_Button;
         
         //setup new listeners
         if ( null != ReSet_Button )
         {
            {
               uScript_Button component = ReSet_Button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = ReSet_Button.AddComponent<uScript_Button>();
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
      if ( prd_anim_obj_previous != prd_anim_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         prd_anim_obj_previous = prd_anim_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Main_Cam_previous != Main_Cam || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Main_Cam_previous = Main_Cam;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Goal_col_previous != Goal_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Goal_col_previous = Goal_col;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Dead_col_previous != Dead_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Dead_col_previous = Dead_col;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ReSet_Button_02_previous != ReSet_Button_02 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != ReSet_Button_02_previous )
         {
            {
               uScript_Button component = ReSet_Button_02_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_23;
                  component.OnButtonDown -= Instance_OnButtonDown_23;
                  component.OnButtonUp -= Instance_OnButtonUp_23;
                  component.OnButtonEnter -= Instance_OnButtonEnter_23;
                  component.OnButtonExit -= Instance_OnButtonExit_23;
                  component.OnButtonDrag -= Instance_OnButtonDrag_23;
               }
            }
         }
         
         ReSet_Button_02_previous = ReSet_Button_02;
         
         //setup new listeners
         if ( null != ReSet_Button_02 )
         {
            {
               uScript_Button component = ReSet_Button_02.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = ReSet_Button_02.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_23;
                  component.OnButtonDown += Instance_OnButtonDown_23;
                  component.OnButtonUp += Instance_OnButtonUp_23;
                  component.OnButtonEnter += Instance_OnButtonEnter_23;
                  component.OnButtonExit += Instance_OnButtonExit_23;
                  component.OnButtonDrag += Instance_OnButtonDrag_23;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != ReSet_Button )
      {
         {
            uScript_Button component = ReSet_Button.GetComponent<uScript_Button>();
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
      if ( null != ReSet_Button_02 )
      {
         {
            uScript_Button component = ReSet_Button_02.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_23;
               component.OnButtonDown -= Instance_OnButtonDown_23;
               component.OnButtonUp -= Instance_OnButtonUp_23;
               component.OnButtonEnter -= Instance_OnButtonEnter_23;
               component.OnButtonExit -= Instance_OnButtonExit_23;
               component.OnButtonDrag -= Instance_OnButtonDrag_23;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.SetParent(g);
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_5.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_6.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_9.SetParent(g);
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_12.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_14.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_20.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_21.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_22.SetParent(g);
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
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_6)
      {
         Relay_DrivenDelay_6();
      }
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
   
   void Instance_OnButtonClick_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_23( );
   }
   
   void Instance_OnButtonDown_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_23( );
   }
   
   void Instance_OnButtonUp_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_23( );
   }
   
   void Instance_OnButtonEnter_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_23( );
   }
   
   void Instance_OnButtonExit_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_23( );
   }
   
   void Instance_OnButtonDrag_23(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_23( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
      Relay_In_2();
   }
   
   void Relay_OnButtonUp_0()
   {
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
   
   void Relay_In_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( prd_anim_obj_previous != prd_anim_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  prd_anim_obj_previous = prd_anim_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterTrigger_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterTrigger_Target_2, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterTrigger_Target_2[ index++ ] = prd_anim_obj;
            
         }
         {
            logic_uScriptAct_AnimatorSetParameterTrigger_Name_2 = local_4_System_String;
            
         }
      }
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.In(logic_uScriptAct_AnimatorSetParameterTrigger_Target_2, logic_uScriptAct_AnimatorSetParameterTrigger_Name_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SetRectTransformPosition2D_Target_5 = local_10_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_SetRectTransformPosition2D_Position_5 = Guide_Cam_ResetPos;
            
         }
      }
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_5.In(logic_uScriptAct_SetRectTransformPosition2D_Target_5, logic_uScriptAct_SetRectTransformPosition2D_Position_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_5.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_6 = Restart_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_6.In(logic_uScriptAct_Delay_Duration_6, logic_uScriptAct_Delay_SingleFrame_6);
      logic_uScriptAct_Delay_DrivenDelay_6 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_6.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_True_21();
      }
   }
   
   void Relay_Stop_6()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_6 = Restart_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_6.Stop(logic_uScriptAct_Delay_Duration_6, logic_uScriptAct_Delay_SingleFrame_6);
      logic_uScriptAct_Delay_DrivenDelay_6 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_6.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_True_21();
      }
   }
   
   void Relay_DrivenDelay_6( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_6 = Restart_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_6 = logic_uScriptAct_Delay_uScriptAct_Delay_6.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_6 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_6.AfterDelay == true )
         {
            Relay_True_21();
         }
      }
   }
   void Relay_In_9()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Main_Cam_previous != Main_Cam || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Main_Cam_previous = Main_Cam;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectPosition_Target_9.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_9, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_9[ index++ ] = Main_Cam;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_9.In(logic_uScriptAct_SetGameObjectPosition_Target_9, logic_uScriptAct_SetGameObjectPosition_Position_9, logic_uScriptAct_SetGameObjectPosition_AsOffset_9, logic_uScriptAct_SetGameObjectPosition_AsLocal_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_9.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SetRectTransformPosition2D_Target_12 = local_11_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_SetRectTransformPosition2D_Position_12 = Player_restart_pos;
            
         }
      }
      logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_12.In(logic_uScriptAct_SetRectTransformPosition2D_Target_12, logic_uScriptAct_SetRectTransformPosition2D_Position_12);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetRectTransformPosition2D_uScriptAct_SetRectTransformPosition2D_12.Out;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_14()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( prd_anim_obj_previous != prd_anim_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  prd_anim_obj_previous = prd_anim_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_14.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_14, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_14[ index++ ] = prd_anim_obj;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_14.In(logic_uScriptAct_AnimatorSetParameterBool_Target_14, logic_uScriptAct_AnimatorSetParameterBool_Name_14, logic_uScriptAct_AnimatorSetParameterBool_Value_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_22();
      }
   }
   
   void Relay_True_20()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_20.True(out logic_uScriptAct_SetBool_Target_20);
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16 = logic_uScriptAct_SetBool_Target_20;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17 = logic_uScriptAct_SetBool_Target_20;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Set_Refresh( );
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_20.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_False_20()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_20.False(out logic_uScriptAct_SetBool_Target_20);
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16 = logic_uScriptAct_SetBool_Target_20;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17 = logic_uScriptAct_SetBool_Target_20;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Set_Refresh( );
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_20.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_True_21()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_21.True(out logic_uScriptAct_SetBool_Target_21);
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16 = logic_uScriptAct_SetBool_Target_21;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17 = logic_uScriptAct_SetBool_Target_21;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Set_Refresh( );
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_21()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_21.False(out logic_uScriptAct_SetBool_Target_21);
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16 = logic_uScriptAct_SetBool_Target_21;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17 = logic_uScriptAct_SetBool_Target_21;
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_16_Set_Refresh( );
      property_isTrigger_Detox_ScriptEditor_Parameter_isTrigger_17_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_22()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( prd_anim_obj_previous != prd_anim_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  prd_anim_obj_previous = prd_anim_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_22.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_22, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_22[ index++ ] = prd_anim_obj;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_22.In(logic_uScriptAct_AnimatorSetParameterBool_Target_22, logic_uScriptAct_AnimatorSetParameterBool_Name_22, logic_uScriptAct_AnimatorSetParameterBool_Value_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_22.Out;
      
      if ( test_0 == true )
      {
         Relay_False_20();
      }
   }
   
   void Relay_OnButtonClick_23()
   {
   }
   
   void Relay_OnButtonDown_23()
   {
      Relay_In_2();
   }
   
   void Relay_OnButtonUp_23()
   {
   }
   
   void Relay_OnButtonEnter_23()
   {
   }
   
   void Relay_OnButtonExit_23()
   {
   }
   
   void Relay_OnButtonDrag_23()
   {
   }
   
}
