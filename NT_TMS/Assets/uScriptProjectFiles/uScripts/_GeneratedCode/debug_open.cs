//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class debug_open : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Buttom = default(UnityEngine.GameObject);
   UnityEngine.GameObject Buttom_previous = null;
   System.String local_4_System_String = "Player_Jump_Vector_Y";
   System.String local_5_System_String = "Player_Jump_Vector_X";
   public UnityEngine.GameObject Toggle_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Toggle_obj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_2 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_2 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_2 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_6 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_6 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_6 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_6;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_7 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_7 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_7 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_7;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_7 = true;
   
   //event nodes
   
   //property nodes
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8 = (float) 0;
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous = null;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9 = (float) 0;
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous = null;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Side_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Up_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      if ( null == property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 || false == m_RegisteredForEvents )
      {
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Buttom_previous != Buttom || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Buttom_previous )
         {
            {
               uScript_Button component = Buttom_previous.GetComponent<uScript_Button>();
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
         
         Buttom_previous = Buttom;
         
         //setup new listeners
         if ( null != Buttom )
         {
            {
               uScript_Button component = Buttom.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Buttom.AddComponent<uScript_Button>();
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
      if ( Toggle_obj_previous != Toggle_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Toggle_obj_previous = Toggle_obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Buttom_previous != Buttom || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Buttom_previous )
         {
            {
               uScript_Button component = Buttom_previous.GetComponent<uScript_Button>();
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
         
         Buttom_previous = Buttom;
         
         //setup new listeners
         if ( null != Buttom )
         {
            {
               uScript_Button component = Buttom.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Buttom.AddComponent<uScript_Button>();
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
      if ( Toggle_obj_previous != Toggle_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Toggle_obj_previous = Toggle_obj;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_8;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_9;
                  
                  //setup new listeners
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Buttom )
      {
         {
            uScript_Button component = Buttom.GetComponent<uScript_Button>();
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
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.SetParent(g);
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_6.SetParent(g);
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_7.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.OnOut += uScriptAct_Toggle_OnOut_2;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.OffOut += uScriptAct_Toggle_OffOut_2;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.ToggleOut += uScriptAct_Toggle_ToggleOut_2;
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
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.OnOut -= uScriptAct_Toggle_OnOut_2;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.OffOut -= uScriptAct_Toggle_OffOut_2;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.ToggleOut -= uScriptAct_Toggle_ToggleOut_2;
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
   
   void uScriptAct_Toggle_OnOut_2(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_2( );
   }
   
   void uScriptAct_Toggle_OffOut_2(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_2( );
   }
   
   void uScriptAct_Toggle_ToggleOut_2(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_2( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
      Relay_Toggle_2();
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
   
   void Relay_OnOut_2()
   {
      Relay_In_6();
   }
   
   void Relay_OffOut_2()
   {
   }
   
   void Relay_ToggleOut_2()
   {
   }
   
   void Relay_TurnOn_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Toggle_obj_previous != Toggle_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Toggle_obj_previous = Toggle_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_2, index + 1);
            }
            logic_uScriptAct_Toggle_Target_2[ index++ ] = Toggle_obj;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.TurnOn(logic_uScriptAct_Toggle_Target_2, logic_uScriptAct_Toggle_IgnoreChildren_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_TurnOff_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Toggle_obj_previous != Toggle_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Toggle_obj_previous = Toggle_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_2, index + 1);
            }
            logic_uScriptAct_Toggle_Target_2[ index++ ] = Toggle_obj;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.TurnOff(logic_uScriptAct_Toggle_Target_2, logic_uScriptAct_Toggle_IgnoreChildren_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Toggle_obj_previous != Toggle_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Toggle_obj_previous = Toggle_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_2, index + 1);
            }
            logic_uScriptAct_Toggle_Target_2[ index++ ] = Toggle_obj;
            
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_2.Toggle(logic_uScriptAct_Toggle_Target_2, logic_uScriptAct_Toggle_IgnoreChildren_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_6 = local_4_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_6.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_6, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_6, out logic_uScriptAct_GetPreferenceKeyFloat_Value_6);
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9 = logic_uScriptAct_GetPreferenceKeyFloat_Value_6;
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_9_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_7 = local_5_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_7.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_7, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_7, out logic_uScriptAct_GetPreferenceKeyFloat_Value_7);
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8 = logic_uScriptAct_GetPreferenceKeyFloat_Value_7;
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_8_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
