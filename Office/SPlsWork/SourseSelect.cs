using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_SOURSESELECT
{
    public class UserModuleClass_SOURSESELECT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput SOURSE_PRESS;
        Crestron.Logos.SplusObjects.DigitalInput SOURSE_GET;
        Crestron.Logos.SplusObjects.DigitalOutput SOURSE_SELECT_OSC;
        ushort X = 0;
        object SOURSE_PRESS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 165;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 167;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWER_OFF  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 169;
                        SOURSE_SELECT_OSC  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 170;
                        Functions.Delay (  (int) ( 200 ) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 174;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SOURSE_PRESS  .Value == SOURSE_GET  .Value))  ) ) 
                            { 
                            __context__.SourceCodeLine = 176;
                            X = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 177;
                            SOURSE_SELECT_OSC  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 181;
                            Functions.Pulse ( 100, SOURSE_SELECT_OSC ) ; 
                            __context__.SourceCodeLine = 182;
                            Functions.Delay (  (int) ( 200 ) ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 165;
                    } 
                
                __context__.SourceCodeLine = 186;
                X = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWER_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 191;
            X = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 192;
            SOURSE_SELECT_OSC  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 193;
            X = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    SOURSE_PRESS = new Crestron.Logos.SplusObjects.DigitalInput( SOURSE_PRESS__DigitalInput__, this );
    m_DigitalInputList.Add( SOURSE_PRESS__DigitalInput__, SOURSE_PRESS );
    
    SOURSE_GET = new Crestron.Logos.SplusObjects.DigitalInput( SOURSE_GET__DigitalInput__, this );
    m_DigitalInputList.Add( SOURSE_GET__DigitalInput__, SOURSE_GET );
    
    SOURSE_SELECT_OSC = new Crestron.Logos.SplusObjects.DigitalOutput( SOURSE_SELECT_OSC__DigitalOutput__, this );
    m_DigitalOutputList.Add( SOURSE_SELECT_OSC__DigitalOutput__, SOURSE_SELECT_OSC );
    
    
    SOURSE_PRESS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURSE_PRESS_OnPush_0, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SOURSESELECT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POWER_OFF__DigitalInput__ = 0;
const uint SOURSE_PRESS__DigitalInput__ = 1;
const uint SOURSE_GET__DigitalInput__ = 2;
const uint SOURSE_SELECT_OSC__DigitalOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
