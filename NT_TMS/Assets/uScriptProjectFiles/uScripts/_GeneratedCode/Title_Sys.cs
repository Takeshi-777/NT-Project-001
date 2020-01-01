//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Title_Sys : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject AC = default(UnityEngine.GameObject);
   UnityEngine.GameObject AC_previous = null;
   public System.Single delayTime = (float) 1;
   System.Int32 local_1_System_Int32 = (int) 1;
   System.String local_10_System_String = "Tap";
   public UnityEngine.GameObject Screen_button = default(UnityEngine.GameObject);
   UnityEngine.GameObject Screen_button_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_LoadLevelByIndex logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0 = new uScriptAct_LoadLevelByIndex( );
   System.Int32 logic_uScriptAct_LoadLevelByIndex_index_0 = (int) 0;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_0 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_0 = (bool) true;
   bool logic_uScriptAct_LoadLevelByIndex_Out_0 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterTrigger logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_6 = new uScriptAct_AnimatorSetParameterTrigger( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterTrigger_Target_6 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterTrigger_Name_6 = "";
   bool logic_uScriptAct_AnimatorSetParameterTrigger_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_12 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_12 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_12 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_12 = true;
   bool logic_uScriptAct_Delay_AfterDelay_12 = true;
   bool logic_uScriptAct_Delay_Stopped_12 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_12 = false;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Screen_button_previous != Screen_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Screen_button_previous )
         {
            {
               uScript_Button component = Screen_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_2;
                  component.OnButtonDown -= Instance_OnButtonDown_2;
                  component.OnButtonUp -= Instance_OnButtonUp_2;
                  component.OnButtonEnter -= Instance_OnButtonEnter_2;
                  component.OnButtonExit -= Instance_OnButtonExit_2;
                  component.OnButtonDrag -= Instance_OnButtonDrag_2;
               }
            }
         }
         
         Screen_button_previous = Screen_button;
         
         //setup new listeners
         if ( null != Screen_button )
         {
            {
               uScript_Button component = Screen_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Screen_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_2;
                  component.OnButtonDown += Instance_OnButtonDown_2;
                  component.OnButtonUp += Instance_OnButtonUp_2;
                  component.OnButtonEnter += Instance_OnButtonEnter_2;
                  component.OnButtonExit += Instance_OnButtonExit_2;
                  component.OnButtonDrag += Instance_OnButtonDrag_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( AC_previous != AC || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         AC_previous = AC;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Screen_button_previous != Screen_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Screen_button_previous )
         {
            {
               uScript_Button component = Screen_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_2;
                  component.OnButtonDown -= Instance_OnButtonDown_2;
                  component.OnButtonUp -= Instance_OnButtonUp_2;
                  component.OnButtonEnter -= Instance_OnButtonEnter_2;
                  component.OnButtonExit -= Instance_OnButtonExit_2;
                  component.OnButtonDrag -= Instance_OnButtonDrag_2;
               }
            }
         }
         
         Screen_button_previous = Screen_button;
         
         //setup new listeners
         if ( null != Screen_button )
         {
            {
               uScript_Button component = Screen_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Screen_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_2;
                  component.OnButtonDown += Instance_OnButtonDown_2;
                  component.OnButtonUp += Instance_OnButtonUp_2;
                  component.OnButtonEnter += Instance_OnButtonEnter_2;
                  component.OnButtonExit += Instance_OnButtonExit_2;
                  component.OnButtonDrag += Instance_OnButtonDrag_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( AC_previous != AC || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         AC_previous = AC;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Screen_button )
      {
         {
            uScript_Button component = Screen_button.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_2;
               component.OnButtonDown -= Instance_OnButtonDown_2;
               component.OnButtonUp -= Instance_OnButtonUp_2;
               component.OnButtonEnter -= Instance_OnButtonEnter_2;
               component.OnButtonExit -= Instance_OnButtonExit_2;
               component.OnButtonDrag -= Instance_OnButtonDrag_2;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_6.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_12.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0.Loaded += uScriptAct_LoadLevelByIndex_Loaded_0;
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
      
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_12)
      {
         Relay_DrivenDelay_12();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0.Loaded -= uScriptAct_LoadLevelByIndex_Loaded_0;
   }
   
   void Instance_OnButtonClick_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_2( );
   }
   
   void Instance_OnButtonDown_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_2( );
   }
   
   void Instance_OnButtonUp_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_2( );
   }
   
   void Instance_OnButtonEnter_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_2( );
   }
   
   void Instance_OnButtonExit_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_2( );
   }
   
   void Instance_OnButtonDrag_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_2( );
   }
   
   void uScriptAct_LoadLevelByIndex_Loaded_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_0( );
   }
   
   void Relay_Loaded_0()
   {
   }
   
   void Relay_In_0()
   {
      {
         {
            logic_uScriptAct_LoadLevelByIndex_index_0 = local_1_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_0.In(logic_uScriptAct_LoadLevelByIndex_index_0, logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_0, logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_0);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnButtonClick_2()
   {
   }
   
   void Relay_OnButtonDown_2()
   {
      Relay_In_6();
   }
   
   void Relay_OnButtonUp_2()
   {
   }
   
   void Relay_OnButtonEnter_2()
   {
   }
   
   void Relay_OnButtonExit_2()
   {
   }
   
   void Relay_OnButtonDrag_2()
   {
   }
   
   void Relay_In_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( AC_previous != AC || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  AC_previous = AC;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterTrigger_Target_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterTrigger_Target_6, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterTrigger_Target_6[ index++ ] = AC;
            
         }
         {
            logic_uScriptAct_AnimatorSetParameterTrigger_Name_6 = local_10_System_String;
            
         }
      }
      logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_6.In(logic_uScriptAct_AnimatorSetParameterTrigger_Target_6, logic_uScriptAct_AnimatorSetParameterTrigger_Name_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterTrigger_uScriptAct_AnimatorSetParameterTrigger_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = delayTime;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_12.In(logic_uScriptAct_Delay_Duration_12, logic_uScriptAct_Delay_SingleFrame_12);
      logic_uScriptAct_Delay_DrivenDelay_12 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_12.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_0();
      }
   }
   
   void Relay_Stop_12()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = delayTime;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_12.Stop(logic_uScriptAct_Delay_Duration_12, logic_uScriptAct_Delay_SingleFrame_12);
      logic_uScriptAct_Delay_DrivenDelay_12 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_12.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_0();
      }
   }
   
   void Relay_DrivenDelay_12( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = delayTime;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_12 = logic_uScriptAct_Delay_uScriptAct_Delay_12.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_12 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_12.AfterDelay == true )
         {
            Relay_In_0();
         }
      }
   }
}
