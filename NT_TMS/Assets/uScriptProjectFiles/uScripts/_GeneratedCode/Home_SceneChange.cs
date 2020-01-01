//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Home_SceneChange : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single _000_Open_Fade = (float) 1;
   public System.Single _001_Change_FadeTime = (float) 2;
   public UnityEngine.GameObject _080_btncomp = default(UnityEngine.GameObject);
   UnityEngine.GameObject _080_btncomp_previous = null;
   public System.Boolean ChoiseGameMode = (bool) false;
   public System.Int32 ChoiseGameStage = (int) 0;
   public UnityEngine.GameObject Fade_Controler = default(UnityEngine.GameObject);
   UnityEngine.GameObject Fade_Controler_previous = null;
   System.Int32 local_16_System_Int32 = (int) 2;
   System.Int32 local_18_System_Int32 = (int) 3;
   System.String local_4_System_String = "";
   System.String local_6_System_String = "Chage";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_23 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_0 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_0 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_0 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_0 = true;
   bool logic_uScriptAct_Delay_AfterDelay_0 = true;
   bool logic_uScriptAct_Delay_Stopped_0 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_0 = false;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_2 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_2 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_2 = "Fade_ON";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_2 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_2 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_5 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_5 = "";
   System.String logic_uScriptCon_CompareString_B_5 = "";
   bool logic_uScriptCon_CompareString_Same_5 = true;
   bool logic_uScriptCon_CompareString_Different_5 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_8 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_8 = "Fade_ON";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_8 = (bool) true;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_8 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_11 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_11 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_11 = true;
   bool logic_uScriptCon_CompareBool_False_11 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_12 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_12 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_12 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_12 = true;
   bool logic_uScriptAct_Delay_AfterDelay_12 = true;
   bool logic_uScriptAct_Delay_Stopped_12 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_12 = false;
   //pointer to script instanced logic node
   uScriptAct_LoadLevelByIndex logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15 = new uScriptAct_LoadLevelByIndex( );
   System.Int32 logic_uScriptAct_LoadLevelByIndex_index_15 = (int) 0;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_15 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_15 = (bool) true;
   bool logic_uScriptAct_LoadLevelByIndex_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_LoadLevelByIndex logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17 = new uScriptAct_LoadLevelByIndex( );
   System.Int32 logic_uScriptAct_LoadLevelByIndex_index_17 = (int) 0;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_17 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_17 = (bool) true;
   bool logic_uScriptAct_LoadLevelByIndex_Out_17 = true;
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_20 = new uScript_GraphEvents( );
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Sender_22 = default(UnityEngine.GameObject);
   System.String event_UnityEngine_GameObject_EventName_22 = "";
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Fade_Controler_previous != Fade_Controler || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Fade_Controler_previous = Fade_Controler;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _080_btncomp_previous != _080_btncomp || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _080_btncomp_previous = _080_btncomp;
         
         //setup new listeners
      }
      if ( null == owner_Connection_23 || false == m_RegisteredForEvents )
      {
         owner_Connection_23 = parentGameObject;
         if ( null != owner_Connection_23 )
         {
            {
               uScript_CustomEvent component = owner_Connection_23.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = owner_Connection_23.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_22;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Fade_Controler_previous != Fade_Controler || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Fade_Controler_previous = Fade_Controler;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _080_btncomp_previous != _080_btncomp || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _080_btncomp_previous = _080_btncomp;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_23 )
         {
            {
               uScript_CustomEvent component = owner_Connection_23.GetComponent<uScript_CustomEvent>();
               if ( null == component )
               {
                  component = owner_Connection_23.AddComponent<uScript_CustomEvent>();
               }
               if ( null != component )
               {
                  component.OnCustomEvent += Instance_OnCustomEvent_22;
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
      if ( null != owner_Connection_23 )
      {
         {
            uScript_CustomEvent component = owner_Connection_23.GetComponent<uScript_CustomEvent>();
            if ( null != component )
            {
               component.OnCustomEvent -= Instance_OnCustomEvent_22;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Delay_uScriptAct_Delay_0.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_2.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_5.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_11.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_12.SetParent(g);
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15.SetParent(g);
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17.SetParent(g);
      logic_uScript_GraphEvents_uScript_GraphEvents_20.SetParent(g);
      owner_Connection_23 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15.Loaded += uScriptAct_LoadLevelByIndex_Loaded_15;
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17.Loaded += uScriptAct_LoadLevelByIndex_Loaded_17;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptEnable += uScript_GraphEvents_uScriptEnable_20;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptDisable += uScript_GraphEvents_uScriptDisable_20;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_20;
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
      logic_uScript_GraphEvents_uScript_GraphEvents_20.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_20.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15.Update( );
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_0)
      {
         Relay_DrivenDelay_0();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_12)
      {
         Relay_DrivenDelay_12();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_20.OnDestroy( );
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15.Loaded -= uScriptAct_LoadLevelByIndex_Loaded_15;
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17.Loaded -= uScriptAct_LoadLevelByIndex_Loaded_17;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptEnable -= uScript_GraphEvents_uScriptEnable_20;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptDisable -= uScript_GraphEvents_uScriptDisable_20;
      logic_uScript_GraphEvents_uScript_GraphEvents_20.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_20;
   }
   
   void Instance_OnCustomEvent_22(object o, uScript_CustomEvent.CustomEventBoolArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Sender_22 = e.Sender;
      event_UnityEngine_GameObject_EventName_22 = e.EventName;
      //relay event to nodes
      Relay_OnCustomEvent_22( );
   }
   
   void uScriptAct_LoadLevelByIndex_Loaded_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_15( );
   }
   
   void uScriptAct_LoadLevelByIndex_Loaded_17(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_17( );
   }
   
   void uScript_GraphEvents_uScriptEnable_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_20( );
   }
   
   void uScript_GraphEvents_uScriptDisable_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_20( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_20( );
   }
   
   void Relay_In_0()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_0 = _000_Open_Fade;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_0.In(logic_uScriptAct_Delay_Duration_0, logic_uScriptAct_Delay_SingleFrame_0);
      logic_uScriptAct_Delay_DrivenDelay_0 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_Stop_0()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_0 = _000_Open_Fade;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_0.Stop(logic_uScriptAct_Delay_Duration_0, logic_uScriptAct_Delay_SingleFrame_0);
      logic_uScriptAct_Delay_DrivenDelay_0 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_DrivenDelay_0( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_0 = _000_Open_Fade;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_0 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay == true )
         {
            Relay_In_2();
         }
      }
   }
   void Relay_In_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Fade_Controler_previous != Fade_Controler || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Fade_Controler_previous = Fade_Controler;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_2, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_2[ index++ ] = Fade_Controler;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_2.In(logic_uScriptAct_AnimatorSetParameterBool_Target_2, logic_uScriptAct_AnimatorSetParameterBool_Name_2, logic_uScriptAct_AnimatorSetParameterBool_Value_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptCon_CompareString_A_5 = local_4_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_5 = local_6_System_String;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_5.In(logic_uScriptCon_CompareString_A_5, logic_uScriptCon_CompareString_B_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_5.Same;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Fade_Controler_previous != Fade_Controler || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Fade_Controler_previous = Fade_Controler;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_8.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_8, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_8[ index++ ] = Fade_Controler;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.In(logic_uScriptAct_AnimatorSetParameterBool_Target_8, logic_uScriptAct_AnimatorSetParameterBool_Name_8, logic_uScriptAct_AnimatorSetParameterBool_Value_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_11 = ChoiseGameMode;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_11.In(logic_uScriptCon_CompareBool_Bool_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_11.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_11.False;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
      if ( test_1 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = _001_Change_FadeTime;
            
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
         Relay_In_11();
      }
   }
   
   void Relay_Stop_12()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = _001_Change_FadeTime;
            
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
         Relay_In_11();
      }
   }
   
   void Relay_DrivenDelay_12( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_12 = _001_Change_FadeTime;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_12 = logic_uScriptAct_Delay_uScriptAct_Delay_12.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_12 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_12.AfterDelay == true )
         {
            Relay_In_11();
         }
      }
   }
   void Relay_Loaded_15()
   {
   }
   
   void Relay_In_15()
   {
      {
         {
            logic_uScriptAct_LoadLevelByIndex_index_15 = local_16_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_15.In(logic_uScriptAct_LoadLevelByIndex_index_15, logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_15, logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_15);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Loaded_17()
   {
   }
   
   void Relay_In_17()
   {
      {
         {
            logic_uScriptAct_LoadLevelByIndex_index_17 = local_18_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_LoadLevelByIndex_uScriptAct_LoadLevelByIndex_17.In(logic_uScriptAct_LoadLevelByIndex_index_17, logic_uScriptAct_LoadLevelByIndex_destroyOtherObjects_17, logic_uScriptAct_LoadLevelByIndex_blockUntilLoaded_17);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_uScriptEnable_20()
   {
      Relay_In_0();
   }
   
   void Relay_uScriptDisable_20()
   {
   }
   
   void Relay_uScriptDestroy_20()
   {
   }
   
   void Relay_OnCustomEvent_22()
   {
      _080_btncomp = event_UnityEngine_GameObject_Sender_22;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( _080_btncomp_previous != _080_btncomp || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            _080_btncomp_previous = _080_btncomp;
            
            //setup new listeners
         }
      }
      local_4_System_String = event_UnityEngine_GameObject_EventName_22;
      Relay_In_5();
   }
   
}
