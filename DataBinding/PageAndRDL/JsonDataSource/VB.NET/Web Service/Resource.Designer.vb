﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Resource
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Web_Service.Resource", GetType(Resource).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to JsonDataSource Sample WebService was started successfully.
        '''</summary>
        Friend Shared ReadOnly Property bodyOfMessage() As String
            Get
                Return ResourceManager.GetString("bodyOfMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {&quot;Customers&quot;:[{&quot;Id&quot;:&quot;ALFKI&quot;,&quot;CompanyName&quot;:&quot;Alfreds Futterkiste&quot;,&quot;ContactName&quot;:&quot;Maria Anders&quot;,&quot;ContactTitle&quot;:&quot;Sales Representative&quot;,&quot;Address&quot;:&quot;Obere Str. 57&quot;,&quot;City&quot;:&quot;Berlin&quot;,&quot;PostalCode&quot;:&quot;12209&quot;,&quot;Country&quot;:&quot;Germany&quot;,&quot;Phone&quot;:&quot;030-0074321&quot;,&quot;Fax&quot;:&quot;030-0076545&quot;},{&quot;Id&quot;:&quot;ANATR&quot;,&quot;CompanyName&quot;:&quot;Ana Trujillo Emparedados y helados&quot;,&quot;ContactName&quot;:&quot;Ana Trujillo&quot;,&quot;ContactTitle&quot;:&quot;Owner&quot;,&quot;Address&quot;:&quot;Avda. de la Constitución 2222&quot;,&quot;City&quot;:&quot;México D.F.&quot;,&quot;PostalCode&quot;:&quot;05021&quot;,&quot;Country&quot;:&quot;Mexico&quot;,&quot;Phone&quot;:&quot;(5) 555-4729&quot;,&quot;Fax&quot;:&quot;(5) 5 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property customers() As String
            Get
                Return ResourceManager.GetString("customers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Message : {0}, StackTrace: {1}.
        '''</summary>
        Friend Shared ReadOnly Property FormatErrorMessage() As String
            Get
                Return ResourceManager.GetString("FormatErrorMessage", resourceCulture)
            End Get
        End Property
    End Class
End Namespace